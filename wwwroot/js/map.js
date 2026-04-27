(() => {
    const shell = document.querySelector('.world-shell');
    if (!shell) {
        return;
    }

    const worldName = shell.dataset.worldName;
    const mapPath = shell.dataset.mapPath;
    const list = document.getElementById('location-list');
    const detail = document.getElementById('location-detail');

    const map = L.map('fantasy-map', {
        crs: L.CRS.Simple,
        minZoom: -2,
        maxZoom: 1
    });

    const bounds = [[0, 0], [1000, 1000]];
    L.imageOverlay(mapPath, bounds).addTo(map);
    map.fitBounds(bounds);

    const typeColors = {
        'Capital City': '#ffcc00',
        'Swamp': '#5cb85c',
        'Mountain Fortress': '#7f8c8d',
        'Sacred Site': '#3498db',
        'Ruins': '#e74c3c'
    };

    const renderDetail = (location) => {
        detail.innerHTML = `
            <h3>${location.name}</h3>
            <p><strong>Region:</strong> ${location.region}</p>
            <p><strong>Type:</strong> ${location.type}</p>
            <p>${location.description}</p>
        `;
    };

    fetch('/api/world')
        .then((response) => response.json())
        .then((world) => {
            world.locations.forEach((location) => {
                const marker = L.circleMarker([location.y * 10, location.x * 10], {
                    radius: 8,
                    color: '#222',
                    weight: 1,
                    fillColor: typeColors[location.type] ?? '#9b59b6',
                    fillOpacity: 0.95
                }).addTo(map);

                marker.bindTooltip(location.name);
                marker.on('click', () => renderDetail(location));

                const item = document.createElement('li');
                item.className = 'location-item';
                item.textContent = `${location.name} (${location.type})`;
                item.addEventListener('click', () => {
                    map.flyTo([location.y * 10, location.x * 10], 0);
                    marker.openTooltip();
                    renderDetail(location);
                });
                list.appendChild(item);
            });

            if (world.locations.length > 0) {
                renderDetail(world.locations[0]);
            }
        })
        .catch(() => {
            detail.innerHTML = `<h3>${worldName}</h3><p>Unable to load world data.</p>`;
        });
})();

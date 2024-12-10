if ("geolocation" in navigator) {
    console.log("localização ok");
} else {
    alert (
        "Não suporta Geoloacalização",
    );
}

navigator.geolocation.getCurrentPosition ((position) =>
{
    document.write(position.coords.latitude, position.coords.longitude);
});
(async () => {
    let granted = false;

    if (Notification.permission === 'granted') {
        granted = true;
    } else if (Notification.permission !== 'denied') {
        let permission = await Notification.requestPermission();
        granted = permission === 'granted' ? true : false;
    }

    btn = document.getElementById("btn");

    btn.addEventListener("click", ()=>{
        if (granted) {
            var notification = Notification("Vou para a Terra", {
                body: "Meu texto aqui!"
            })}

            notification.addEventListener('click', () => {

                window.open('https://www.youtube.com/watch?v=6UkoAlTLDz8', '_blank');
            })
    });
}
)()
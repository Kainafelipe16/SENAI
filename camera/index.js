const video = document.querySelector("video")

navigator.mediaDevices.getUserMedia(
    {video:true}
).then(stream => {
    video.srcOject = stream;
    video.play;
})
.catch(error => {
    console.log(error);
})

btn = document.querySelector("button");

btn.addEventListener("click", ()=>{
    let canvas = document.querySelector("canvas");
    canvas.height = video.videoHeight;
    canvas.width = video.videoWidth;
    let context = canvas.getContext("2d");
    context.drawImage(video,0,0)
    let meulink = document.createElement("a")
    meulink.download = "fot.png"
    meulink.href = canvas.toDataURL();
    meulink.textContent = "baixe sua foto";
    document.body.appendChild(meulink)
})
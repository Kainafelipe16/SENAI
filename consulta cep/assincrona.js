function tempo (){
    return new Promise ((resolve)=>{
        setTimeout(()=>{
            document.write("meio");
            resolve();
        }, 2000)
    })
}

async function rodar (){
    document.write("início");
        await tempo();
        document.write("fim");
}
rodar();
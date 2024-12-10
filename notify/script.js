$('btn').click(
    ()=>{
        let senha1 = $("#senha1").val();
        let senha2 = $("#senha1").val();

        if (senha1 != senha2){
            $.notify("As senhas não conferem", "error")
        } else {
            $.notify("As senhas estão corretas", {
                className: 'sucess',
                position: "top left"
            })
        }
    }
);

$("email").focus(
    ()=>{
        $("#email").notify("Digite seu email com @", "info");
    }
)
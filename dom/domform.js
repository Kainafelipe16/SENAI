const flogin =()=>{
    let login = "Kainã";
    let senha = "16072006";
    if ((login == document.forms["frmLogin"]["txtLogin"].value)
    && (senha==document.forms["frmLogin"]["pwdSenha"].value))
    {
        return true;
    }
    else{
        alert("Úsuaruo ou senha estão incorretos");
        return false;
    }
}
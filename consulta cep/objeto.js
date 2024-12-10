const objeto = [
    {
        cidade : "Guararapes",
        estado : "São Paulo",
        pais : "Brasil",
    
    },
        {
            cidade : "Barueri",
            estado : "São Paulo",
            pais : "Brasil",
        },
]

document.write(objeto)

//converter objeto para JSON
const objetojson = JSON.stringify(objeto)
document.write(objetojson)

//converter JSON para objeto
const jsonobjeto = JSON.parse(objetojson)
document.write(jsonobjeto)
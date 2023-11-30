window.onload = function () {
    listarTipoMedicamento();
}

function listarTipoMedicamento() {
    pintar({
        url: "TipoMedicamento/listarTipoMedicamento",
        cabeceras: ["Id Tipo Medicamento", "Nombre", "Descripcion"],
        propiedades: ["idTipomedicamento", "nombre", "descripcion"]

    })


    //fetchGet("TipoMedicamento/listarTipoMedicamento", "json", function (res) {
        //var contenido = "";
        
        //document.getElementById("divTabla").innerHTML = contenido;
    //});
}
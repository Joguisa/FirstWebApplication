window.onload = function () {
    listarTipoMedicamento();
}

function listarTipoMedicamento() {
    pintar({
        url: "TipoMedicamento/listarTipoMedicamento",
        cabeceras: ["Id Tipo Medicamento", "Nombre", "Descripcion"],
        propiedades: ["idTipomedicamento", "nombre", "descripcion"]

    })
}
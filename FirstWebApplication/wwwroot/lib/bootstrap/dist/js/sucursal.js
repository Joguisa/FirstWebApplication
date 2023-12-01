window.onload = function () {
    listarSucursal();
}

function listarSucursal() {
    pintar({
        url: "Sucursal/listarSucursal",
        cabeceras: ["Id Sucursal", "Nombre", "Dirección"],
        propiedades: ["iidsucursal", "nombre", "direccion"]
    })
}

function Buscar() {
    var nombresucursal = document.getElementById("txtnombrebusqueda").value;
    pintar({
        url: "Sucursal/filtrarSucursal/?nombresucursal=" + nombresucursal,
        cabeceras: ["Id Sucursal", "Nombre", "Dirección"],
        propiedades: ["iidsucursal", "nombre", "direccion"]
    })
}
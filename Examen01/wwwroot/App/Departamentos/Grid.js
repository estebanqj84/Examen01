"use strict";
var DepartamentosGrid;
(function (DepartamentosGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar este registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Departamentos/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    DepartamentosGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(DepartamentosGrid || (DepartamentosGrid = {}));
//# sourceMappingURL=Grid.js.map
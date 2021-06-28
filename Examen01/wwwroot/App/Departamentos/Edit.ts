namespace DepartamentosEdit {

    "use strict";
    var DepartamentosEdit;
    (function (DepartamentosEdit) {
        var Formulario = new Vue({
            data: {
                Formulario: "#FormEdit"
            },
            mounted: function () {
                CreateValidator(this.Formulario);
            }
        });
        Formulario.$mount("#AppEdit");
    })(DepartamentosEdit || (DepartamentosEdit = {}));
    //# sourceMappingURL=Edit
    
}
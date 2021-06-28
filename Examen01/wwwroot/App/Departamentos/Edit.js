"use strict";
var DepartamentosEdit;
(function (DepartamentosEdit_1) {
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
})(DepartamentosEdit || (DepartamentosEdit = {}));
//# sourceMappingURL=Edit.js.map
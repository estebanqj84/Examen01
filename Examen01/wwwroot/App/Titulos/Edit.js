"use strict";
var TitulosEdit;
(function (TitulosEdit_1) {
    "use strict";
    var TitulosEdit;
    (function (TitulosEdit) {
        var Formulario = new Vue({
            data: {
                Formulario: "#FormEdit"
            },
            mounted: function () {
                CreateValidator(this.Formulario);
            }
        });
        Formulario.$mount("#AppEdit");
    })(TitulosEdit || (TitulosEdit = {}));
    //# sourceMappingURL=Edit
})(TitulosEdit || (TitulosEdit = {}));
//# sourceMappingURL=Edit.js.map
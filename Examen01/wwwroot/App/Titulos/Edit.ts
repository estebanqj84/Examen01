namespace TitulosEdit {
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
}
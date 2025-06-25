(function ($) {
	app.modals.ProvincesCreateModal = function () {
		var _modalManager;
		var _$form = null;
		var _provinceAppService = abp.services.app.provinces;
		this.init = function(modalManager) {
			_modalManager = modalManager;
			_$form = _modalManager.getModal().find('#ProvincesCreateForm');

			_$form.validate({
				rules: {
					Name: {
						required: true,
						minlength: 2,
					},
					DisplayName: {
						required: true,
						minlength: 2,
					}
				},
				messages: {
					Name: {
						required: abp.localization.localize("PleaseEnterAName", "VietNamTourism"),
						minlength: abp.localization.localize("NameMustConsistOfAtLeast2Characters", "VietNamTourism")
					},
					DisplayName: {
						required: abp.localization.localize("PleaseEnterADisplayName", "VietNamTourism"),
						minlength: abp.localization.localize("DisplayNameMustConsistOfAtLeast2Characters", "VietNamTourism")
					}
				},
				errorClass: "text-danger",
				errorPlacement: function (error, element) {
					error.insertAfter(element);
				},
				submitHandler: function (form) {
				}
			})

			this.save = function () {
				_$form = _modalManager.getModal().find('#ProvincesCreateForm');
				var dataInput = {};
				dataInput.Name = $("#Name").val();
				dataInput.DisplayName = $("#DisplayName").val();
				dataInput.Code = $("#CodeProvince").val();
				dataInput.Description = $("#Description").val();
				dataInput.Region = $("#Region").val();

				abp.ui.setBusy(_modalManager.getModal());

				_provinceAppService
					.create(dataInput)
					.done(function (result) {
						abp.notify.info(abp.localization.localize("SavedSuccessfully"), "VietNamTourism");
						_modalManager.close();
					})
					.always(function () {
						abp.ui.clearBusy(_modalManager.getModal());
					});
			}
		}
	};
})(jQuery);
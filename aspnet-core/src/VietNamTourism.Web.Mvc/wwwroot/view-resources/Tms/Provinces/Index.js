﻿(function ($) {
  var _provinceAppService = abp.services.app.provinces;
  _$table = $("#ProvincesTable");

  var _createModal = new app.ModalManager({
    viewUrl: abp.appPath + 'Tms/Provinces/CreateModal',
    scriptUrl: abp.appPath + 'view-resources/Tms/Provinces/_CreateModal.js',
    modalClass: 'ProvincesCreateModal',
    modalType: 'modal-xl'
  });

  var _editModal = new app.ModalManager({
    viewUrl: abp.appPath + 'Tms/Provinces/EditModal',
    scriptUrl: abp.appPath + 'view-resources/Tms/Provinces/_EditModal.js',
    modalClass: 'ProvincesEditModal',
    modalType: 'modal-xl'
  })

  $('#ProvinceCreateModal').on('click', function () {
    //alert("duyanh");
    _createModal.open();
  });
  $('#ProvincesTable').on('click', '.btn-edit', function (e) {
    e.preventDefault();
    const id = $(this).data('id');

    _editModal.open({ id });
  });

  var _$provincesTable = _$table.DataTable({
    paging: true,
    serverSide: true,
    processing: true,
    listAction: {
      ajaxFunction: _provinceAppService.getAllProvinces,
      inputFilter: function () {
        return $("#RolesSearchForm").serializeFormToObject(true);
      },
    },
    buttons: [
      {
        name: "refresh",
        text: '<i class="fas fa-redo-alt"></i>',
        action: () => _$provincesTable.draw(false),
      },
    ],
    responsive: {
      details: {
        type: "column",
      },
    },
    columnDefs: [
      {
        targets: 0,
        className: "control",
        defaultContent: "",
        orderable: false,
      },
      {
        targets: 1,
        className: "dt-center",
        data: "code",
      },
      {
        targets: 2,
        className: "dt-center",
        data: "displayName",
        render: (data, type, row, meta) => {
          return row.displayName;
        }
      },
      {
        targets: 3,
        className: "dt-center",
        data: "description",
        render: (data, type, row, meta) => {
          if (row.description) {
            return row.description;
          }
          return abp.localization.localize("None", "VietNamTourism")
        }
      },
      {
        targets: 4,
        className: "dt-center",
        data: "regionValue",
        render: (data, type, row, meta) => {
          return `<span class="badge badge-primary"> ${abp.localization.localize(row.regionValue, "VietNamTourism")}</span>`;
        }
      },
      {
        targets: 5,
        data: null,
        className: 'dt-center',
        orderable: false,
        autoWidth: false,
        defaultContent: '',
        render: (data, type, row, meta) => {
          return `
            <div class="dropdown">
              <button class="btn btn-primary btn-sm dropdown-toggle" type="button" id="dropdownMenuButton-${row.id}" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                Actions
              </button>
              <div class="dropdown-menu" aria-labelledby="dropdownMenuButton-${row.id}">
                <a class="dropdown-item btn-edit" id="btn-edit" href="#" data-id="${row.id}">Edit</a>
                <a class="dropdown-item btn-delete" href="#" data-id="${row.id}" data-name="${row.displayName}">Delete</a>
              </div>
            </div>
          `;
        }
      }
    ],
  });

  $("#ProvincesTable").on("click", ".btn-delete", function () {
    var id = $(this).data("id");
    var name = $(this).data("name");
    deleteProvince(id, name);
  })

  function deleteProvince(provinceId, provinceName) {
    abp.message.confirm(
      abp.utils.formatString(abp.localization.localize("AreYouSureWantToDelete", "VietNamTourism"), provinceName),
      null,
      (isConfirmed) => {
        if (isConfirmed) {
          _provinceAppService
            .deleteProvince(
              provinceId,
            )
            .done(() => {
              abp.notify.info(abp.localization.localize("SuccessfullyDeleted"));
              _$provincesTable.ajax.reload();
            });
        }
      },
    );
  }



})(jQuery);
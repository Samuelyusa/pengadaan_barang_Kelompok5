$(document).ready(function () {
    let myTableBarang = $('#MyTableBarang').DataTable({
        ajax: {
            url: "https://localhost:44308/api/Product",
            dataSrc: "data",
            dataType: "JSON"
        },
        columns: [
            {
                data: "null",
                "render": function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
                data: "namaProduk"
            },
            {
                data: "stockProduct"
            },
            {
                data: "idSatuanNavigation.nama"
            },
            {
                data: "hargaProduct"
            },
            {
                data: "id",
                render: function (data, type, row) {
                    return `<button class="btn btn-success" data-toggle="modal" data-target="#editBarang" onclick="getbyid('${data}')">Ubah</button>`;
                }
            },
        ],
    });
});


//function Insert(event) {
//    event.preventDefault();
//    var obj = new Object;

//    obj.id = 0;
//    obj.namaProduk = $("#UpdateNamaProduct").val();
//    obj.stockProduct = parseInt($("#UpdateStockProduct").val());
//    obj.idSatuanNavigation.nama = $("#UpdateSatuanProduct").val();
//    obj.hargaProduct = parseInt($("#UpdateHargaProduct").val());

//    $.ajax({
//        contentType: "application/json",
//        url: "https://localhost:44308/api/Product",
//        type: "POST",
//        data: JSON.stringify(obj)
//    }).done((result) => {
//        alert("Suppleir nerhasil ditambah");
//        $('#MyTableBarang').DataTable().ajax.reload();
//    })

//}

function getbyid(stringURL) {
    $.ajax({
        url: "https://localhost:44308/api/Product/" + stringURL
    }).done((result) => {
        console.log(result);
        $("#UpdateIdProduct").val(result.data.id);
        $("#UpdateNamaProduct").val(result.data.namaProduk);
        $("#UpdateStockProduct").val(result.data.stockProduct);
        $("#UpdateSatuanProduct").val(result.data.idSatuanNavigation.nama);
        $("#UpdateSatuanProductId").val(result.data.idSatuan);
        $("#UpdateHargaProduct").val(result.data.hargaProduct);
    }).fail((error) => {
        console.log(error);
    })
}

function updateBarang() {
    event.preventDefault();
    var obj = new Object();

    obj.id = parseInt($("#UpdateIdProduct").val());
    obj.namaProduk = $("#UpdateNamaProduct").val();
    obj.stockProduct = parseInt($("#UpdateStockProduct").val());
    obj.idSatuan = parseInt($("#UpdateSatuanProductId").val());
    obj.hargaProduct = parseInt($("#UpdateHargaProduct").val());
    $.ajax({
        contentType: "application/json",
        url: "https://localhost:44308/api/Product/" + obj.id,
        type: "PUT",
        data: JSON.stringify(obj)
    }).done((result) => {
        Swal.fire(
            'Berhasil!',
            'Data Berhasil Diubah!',
            'success'
        )
        $('#MyTableBarang').DataTable().ajax.reload();
    })

}




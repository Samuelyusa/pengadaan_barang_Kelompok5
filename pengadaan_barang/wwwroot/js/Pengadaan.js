$.ajax({
    url: "https://localhost:44308/api/Pengadaan",
    type: "GET"
}).done((result) => {
    console.log(result);
})

//$(function () {
//    AjaxCall('/Pengadaan/GetBarang', null).done(function (response) {
//        if (response.length > 0) {
//            $('#UpdateBarangList').html('');
//            var options = '';
//            options += '<option value="Select">Select</option>';
//            for (var i = 0; i < response.length; i++) {
//                options += '<option value="' + response[i] + '">' + response[i] + '</option>';
//            }
//            $('#UpdateBarangList').append(options);
//        }
//    }).fail(function (error) {
//        alert(error.StatusText);
//    });
//});

//function AjaxCall(url, data, type) {
//    return $.ajax({
//        url: url,
//        type: type ? type : 'GET',
//        data: data,
//        contentType: 'application/json'
//    });
//}   

$(document).ready(function () {
    let myTable = $('#MyTablePengadaan').DataTable({
        ajax: {
            url: "https://localhost:44308/api/Pengadaan",
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
                data: "idBarangNavigation.namaProduk"
            },
            {
                data: "idSupplierNavigation.nama"
            },
            {
                data: "kuantitas"
            },
            {
                data: "totals"
            },
            {
                data: "idDivisiNavigation.nama"
            },
            {
                data: "idStatusNavigation.name"
            },
            {
                data: "id",
                render: function (data, type, row) {
                    return `<button class="btn btn-info btn-sm" data-toggle="modal" data-target="#editPengadaan" onclick="getbyid('${data}')">Ubah</button>`;
                }
            },
        ],
    });
});


function Insert(event) {
    event.preventDefault();
    var obj = new Object;

    obj.id = 0;
    obj.idBarangNavigation.namaProduk = $("#UpdatePengadaanNamaBarang").val()
    obj.idSupplierNavigation.nama = $("#UpdatePengadaanSupplier").val()
    obj.kuantitas = $("#UpdatePengadaanKuantitas").val()
    obj.totals = $("#UpdatePengadaanTotal").val()
    obj.idDivisi = $("#UpdatePengadaanDivisi").val()
    obj.idStatus = $("#UpdatePengadaanStatus").val()
    $.ajax({
        contentType: "application/json",
        url: "https://localhost:44308/api/Pengadaan",
        type: "POST",
        data: JSON.stringify(obj)
    }).done((result) => {
        alert("Suppleir nerhasil ditambah");
        $('#MyTablePengadaan').DataTable().ajax.reload();
    })

}

function getbyid(stringURL) {
    $.ajax({
        url: "https://localhost:44308/api/Pengadaan/" + stringURL
    }).done((result) => {
        console.log(result);
        $("#UpdatePengadaanId").val(result.data.id);
        $("#UpdatePengadaanNamaBarang").val(result.data.idBarangNavigation.namaProduk);
        $("#UpdatePengadaanSupplier").val(result.data.idSupplierNavigation.nama);
        $("#UpdatePengadaanKuantitas").val(result.data.kuantitas);
        $("#UpdatePengadaanTotal").val(result.data.totals);
        $("#UpdatePengadaanDivisi").val(result.data.idDivisiNavigation.nama);
        $("#UpdatePengadaanStatus").val(result.data.idStatusNavigation.name);


    }).fail((error) => {
        console.log(error);
    })
}

function getDetails(stringURL) {
    $.ajax({
        url: "https://localhost:44308/api/Pengadaan/" + stringURL
    }).done((result) => {
        console.log(result);
        //$("#UpdatePengadaanId").val(result.data.id);
        $("#UpdatePengadaanNamaBarang").html(result.data.idBarangNavigation.namaProduk);
        $("#UpdatePengadaanSupplier").html(result.data.idSupplierNavigation.nama);
        $("#UpdatePengadaanSupplierAlamat").html(result.data.idSupplierNavigation.alamat);
        $("#UpdatePengadaanSupplierKota").html(result.data.idSupplierNavigation.kota);
        $("#UpdatePengadaanKuantitas").html(result.data.kuantitas);
        $("#UpdatePengadaanHarga").html(result.data.idBarangNavigation.hargaProduct); 


    }).fail((error) => {
        console.log(error);
    })
}

function getDetails1(stringURL) {
    $.ajax({
        url: "https://localhost:44308/api/Pengadaan/" + stringURL
    }).done((result) => {
        console.log(result);
        //$("#UpdatePengadaanId").val(result.data.id);
        $("#UpdatePengadaanNamaBarang1").html(result.data.idBarangNavigation.namaProduk);
        $("#UpdatePengadaanSupplier1").html(result.data.idSupplierNavigation.nama);
        $("#UpdatePengadaanSupplierAlamat1").html(result.data.idSupplierNavigation.alamat);
        $("#UpdatePengadaanSupplierKota1").html(result.data.idSupplierNavigation.kota);
        $("#UpdatePengadaanKuantitas1").html(result.data.kuantitas);
        $("#UpdatePengadaanHarga1").html(result.data.idBarangNavigation.hargaProduct);


    }).fail((error) => {
        console.log(error);
    })
}

function updatePengadaan() {
    event.preventDefault();
    var obj = new Object();

    obj.id = parseInt($("#UpdatePengadaanId").val());
    obj.idBarang = parseInt($("#UpdatePengadaanNamaBarang").val());
    obj.idSupplier = parseInt($("#UpdatePengadaanSupplier").val());
    obj.kuantitas = parseInt($("#UpdatePengadaanKuantitas").val());
    obj.totals = parseInt($("#UpdatePengadaanTotal").val());
    obj.idDivisi = parseInt($("#UpdatePengadaanDivisi").val());
    obj.idStatus = parseInt($("#UpdatePengadaanStatus").val());

    $.ajax({
        contentType: "application/json",
        url: "https://localhost:44308/api/Pengadaan/" + obj.id,
        type: "PUT",
        data: JSON.stringify(obj)
    }).done((result) => {
        Swal.fire(
            'Berhasil!',
            'Data Pengadaan Berhasil Diubah!',
            'success'
        )
        $('#MyTableSupplier').DataTable().ajax.reload();
    })

}




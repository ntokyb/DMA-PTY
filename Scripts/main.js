function init() {
    $.ajax({
        url: "https://financialmodelingprep.com/api/v3/forex/EURUSD",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            $('.cardTitle').text(data.ticker);
            $('#open').text(data.open);
            $('#DateNow').text(data.date);
            $('#Ask').text(data.ask);
            $('#Low').text(data.low);
            $('#High').text(data.high);
        }
    });
}
if ($('.bg-gradient-primary').length) {
    init();
}

function initSymbol() {
    let dropdown = $('#symbol-dropdown');
    dropdown.empty();

    dropdown.append('<option selected="true" disabled>Select Company</option>');
    dropdown.prop('selectedIndex', 0);
    const url = 'https://financialmodelingprep.com/api/v3/company/stock/list';
    $.getJSON(url, function (data) {
        cache: true,
        $.each(data.symbolsList, function (i, entry) {
            dropdown.append($('<option></option>').attr('value', data.symbolsList[i].symbol).text(data.symbolsList[i].name));
        });
    });
}
if ($('#companyValuation').length) {
    initSymbol();
}
(function () {
    $symboldropdown = $('#symbol-dropdown');
    var cache = {};
    return (function ($symboldropdown) {
        return cache[$symboldropdown] || (cache[$symboldropdown] = jQuery($symboldropdown));
    });
}) ();

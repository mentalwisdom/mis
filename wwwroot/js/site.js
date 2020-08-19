// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
Number.prototype.toMoney = function (decimals, decimal_sep, thousands_sep) {
    var n = this,
        c = isNaN(decimals) ? 2 : Math.abs(decimals), //if decimal is zero we must take it, it means user does not want to show any decimal
        d = decimal_sep || '.', //if no decimal separator is passed we use the dot as default decimal separator (we MUST use a decimal separator)

        /*
        according to [https://stackoverflow.com/questions/411352/how-best-to-determine-if-an-argument-is-not-sent-to-the-javascript-function]
        the fastest way to check for not defined parameter is to use typeof value === 'undefined' 
        rather than doing value === undefined.
        */
        t = (typeof thousands_sep === 'undefined') ? ',' : thousands_sep, //if you don't want to use a thousands separator you can pass empty string as thousands_sep value

        sign = (n < 0) ? '-' : '',

        //extracting the absolute value of the integer part of the number and converting to string
        i = parseInt(n = Math.abs(n).toFixed(c)) + '',

        j = ((j = i.length) > 3) ? j % 3 : 0;
    return sign + (j ? i.substr(0, j) + t : '') + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : '');
}
String.prototype.yim = function (length) {
    return this.length > length ? this.substring(0, length) + "..." : this;
}
// Write your JavaScript code.
function op(value, text) {
    return '<option value="' + value + '">' + text + '</option>';
}//ef

function td(d) {
    return '<td>' + d + '</td>';
}
function tr(r) {
    return '<tr>' + r + '</tr>';
}
function goHilight(target) {
    $(target).css('border', 'solid 2px red');
    $('html, body').animate({
        scrollTop: $(target).offset().top
    }, 2000);
}//ef
function unHilight(target) {
    $(target).css('border', '1px solid rgba(0, 0, 0, 0.125)');

}//ef
function scrollToId(target) {
    var elmnt = document.getElementById(target);
    elmnt.scrollIntoView();
}//ef

function anc_post(param, yes, no) {
    $('#loadingmessage').show();
    var option = {
        url: param.url,
        data: param.data,
        type: 'POST',
        timeout: 30000
    };
    var bot = $.ajax(option)
        .done(function (res) {
            $('#loadingmessage').hide();
            if (res.error == 1) {
                no({ side: 'server', message: res.message,data:res.data });
            } else {

                yes({ side: 'server', message: res.message, data: res.data });
            }
        })
        .fail(function (xhr, status, error) {
            //Ajax request failed.
            $('#loadingmessage').hide();
            if (xhr.statusText == "timeout") {
                bot.abort();
                no({ side: 'server', message: 'timeout' });
            }
            else if (xhr.status == 0) {
                no({ side: 'server', message: 'connection refused' });
            }
            else if (xhr.status == 404) {
                no({ side: 'server', message: 'service api not found.' });
            }
        });
    // .always(
    //     function () {
    //         $('#loadingmessage').hide();
    //     }
    // );

} //ef
function anc_get(param, yes, no) {
    $('#loadingmessage').show();
    var option = {
        url: param.url,
        type: 'GET',
        timeout: 30000
    };
    var bot = $.ajax(option)
        .done(function (res) {
            $('#loadingmessage').hide();
            if (res.error == 1) {
                no({ side: 'server', message: res.message,data:null });
            } else {
                yes({ side: 'server', message: res.message,data: res.data  });
            }
        })
        .fail(function (xhr, status, error) {
            //Ajax request failed.
            $('#loadingmessage').hide();
            console.log("main:", xhr);
            if (xhr.statusText == "timeout") {
                bot.abort();
                no({ side: 'server', message: 'timeout' });
            }
            else if (xhr.status == 0) {
                no({ side: 'server', message: 'connection refused' });
            }
            else if (xhr.status == 404) {
                no({ side: 'server', message: 'service api not found.' });
            }
        });
    // .always(
    //     function(){
    //         $('#loadingmessage').hide();
    //     }
    // );

} //ef

function anc_exportFile(url, emsg) {
    $('#loadingmessage').show();
    var option = {
        url: url,
        type: 'GET',
        timeout: 30000
    };
    var bot = $.ajax(option)
        .done(function (res) {
            $('#loadingmessage').hide();
            window.location = res.filename;

        })
        .fail(function (xhr, status, error) {
            //Ajax request failed.
            $('#loadingmessage').hide();
            if (xhr.statusText == "timeout") {
                bot.abort();
                alert('error>' + emsg + ",timeout");
            }
            else if (xhr.status == 0) {
                alert('error>' + emsg + ",connection refused");
            }
            else if (xhr.status == 404) {
                alert('error>' + emsg + ",service api not found");
            }
        });

}//ef

function graph(id, title, label, data, w1, w2, zoom2, lx, ly, oy, cx = 0) {
    var options = {
        labels: label,
        series: data,
        title: {
            text: title,
            align: 'center',
            offsetX: -40,
            style: {
                fontSize: '20px',
                fontWeight: 'bold',
                fontFamily: undefined,
                color: '#263238'
            },
        },
        legend: {
            fontSize: '15px',
            horizontalAlign: 'right',
            offsetX: lx,
            offsetY: ly,
            floating: false,
        },
        chart: {
            type: 'pie',
            width: w1,
            height: 'auto',

            events: {
                legendClick: function (chartContext, index, config) {
                    console.log(ls[0][index]);
                }
            }


        },
        tooltip: {
            y: {
                formatter: function (value) {
                    return value.toLocaleString();
                }
            }
        },


        responsive: [{
            breakpoint: 400,
            options: {

                chart: {
                    width: w2,
                    offsetX: cx

                },
                legend: {
                    position: 'top',
                    fontSize: '10px',
                    floating: false
                },
                plotOptions: {
                    pie: {
                        offsetY: oy,
                        customScale: zoom2
                    }
                }
            }
        }
        ]
    };
    var chart = new ApexCharts(document.querySelector(id), options);
    chart.render();
    return chart;

} //ef

function trend(id, data, title) {
    var options = {
        series: [{
            data: data
        }],
        chart: {
            type: 'area',
            height: 160,
            width: 300,
            sparkline: {
                enabled: true
            },
        },
        stroke: {
            curve: 'straight'
        },
        fill: {
            opacity: 0.3,
        },
        yaxis: {
            min: 0
        },
        title: {
            text: title,
            offsetX: 0,
            style: {
                fontSize: '24px',
            }
        }
    };
    var chart = new ApexCharts(document.querySelector(id), options);
    chart.render();
    return chart;


} //ef

function line(id, name, title, x_label, y_label, data, w1, h1) {
    var options = {
        series: [{
            data: data,
            name: title,

        }],
        
        dataLabels: {
            enabled: false,
        },
        chart: {
            type: 'line',
            width: w1,
            //height: 'auto',
            height: h1,
            zoom: {
                enabled: false
            }
           
        },
        xaxis: {
            categories: x_label,
            labels:{
                style: {

                    fontSize: '20px',
                    fontFamily: 'Helvetica, Arial, sans-serif',
                    fontWeight: 400,

                },
            }
        },
        yaxis: {
           
            labels: {
                style: {

                    fontSize: '18px',
                    fontFamily: 'Helvetica, Arial, sans-serif',
                    fontWeight: 400,

                },
            }
        }
        



    };
    var chart = new ApexCharts(document.querySelector(id), options);
    chart.render();
    return chart;

} //ef



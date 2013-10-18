//调用API
function getJosnDataByAPI(url, fun) {
    $.ajax({
        url: url,
        type: "get",
        timeout: 100000,
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: fun,
        success: function (data) {
            //alert(data);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
//            alert(XMLHttpRequest.status);
//            alert(XMLHttpRequest.readyState);
            alert(textStatus);  
        }
    });
}

//得到昨天的日期
function getYestoday(date) {
    var yesterday_milliseconds = date.getTime() - 1000 * 60 * 60 * 24;
    var yesterday = new Date();
    yesterday.setTime(yesterday_milliseconds);

    var strYear = yesterday.getFullYear();
    var strDay = yesterday.getDate();
    var strMonth = yesterday.getMonth() + 1;
    if (strMonth < 10) {
        strMonth = "0" + strMonth;
    }
    datastr = strYear + "-" + strMonth + "-" + strDay;
    return datastr;
}
function getAllDate(begin, end) {
    var ab = begin.split("-");
    var ae = end.split("-");
    var db = new Date();
    db.setUTCFullYear(ab[0], ab[1] - 1, ab[2]);
    var de = new Date();
    de.setUTCFullYear(ae[0], ae[1] - 1, ae[2]);
    var unixDb = db.getTime();
    var unixDe = de.getTime();
    var xdata = [];
    for (var k = unixDb; k <= unixDe; ) {
        xdata.push(GetDate((new Date(parseInt(k)))));
        k = k + 24 * 60 * 60 * 1000;
    }
    return xdata;
}
function GetDate(d) {
    return d.getFullYear() + "-" + (d.getMonth() + 1) + "-" + d.getDate();
}

function bubbleSort(data) {
    for (var i = 0; i < data.length; i++) {
        for (var j = i; j < data.length; j++) {
            if (parseFloat(data[i].pvnum) < parseFloat(data[j].pvnum)) {
                //交换两个元素的位置
                var temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }
        }
    }
    return data;
}

function bSort(arr) {
    for (var i = 0; i < arr.length; i++) {
        for (var j = i; j < arr.length; j++) {
            if (parseFloat(arr[i]) < parseFloat(arr[j])) {
                //交换两个元素的位置
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}
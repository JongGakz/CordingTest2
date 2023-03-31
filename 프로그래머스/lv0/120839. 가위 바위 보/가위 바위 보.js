function solution(rsp) {
    return rsp.split("").map((n) => {
        if(n === "2") {return "0"}
        else if (n === "0") {return "5";}
        else {return "2"}
    }).join("");
}
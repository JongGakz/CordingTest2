function solution(rsp) {
    let split = rsp.split("");

    for (let i = 0 ; i< rsp.length; i++) {
        if (split[i] === "2") split[i] = "0";
        else if (split[i] === "5") split[i] = "2";
        else split[i] =  "5"
    }
    return split.join("");
}
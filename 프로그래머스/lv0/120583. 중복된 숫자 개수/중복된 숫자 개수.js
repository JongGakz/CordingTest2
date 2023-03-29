function solution(array, n) {
    let count = 0;
    for(let i of array) {
        if(i === n) count++;
    }
    return count;
}


const merge_sort = (arr) => {
    let n = arr.length;
    if (n > 1) {
        let mid = n / 2
        let left = arr.slice(0, mid);
        let right = arr.slice(mid);
        left = merge_sort(left);
        right = merge_sort(right);
        arr = merge(left, right, arr);
    }
    return arr
}

const merge = (left, right, arr) => {
    let i = j = k = 0;
    while (i < left.length && j < right.length) {
        if (left[i] <= right[j]) {
            arr[k] = left[i];
            i += 1;
        } else {
            arr[k] = right[j]
            j += 1;
        }
        k += 1;
    }
    // if (i < left.length) {
    //     arr = [...arr.slice(0, k), ...left.slice(i)];
    // } else {
    //     arr = [...arr.slice(0, k), ...right.slice(j)];
    // }
    return arr
}

let arr = [4, 5, 1, 2, 3, 0, 6];
console.log(merge_sort(arr));


const merge_sort = (arr) => {
    let n = arr.length;
    if (n > 1) {
        let mid = Math.floor(n / 2)
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
    if (i < left.length) {
        console.log("arr", arr)
        arr = [...arr.slice(0, k), ...left.slice(i)];
    } else {
        arr = [...arr.slice(0, k), ...right.slice(j)];
    }
    console.log("final", arr)
    return arr
}

let arr = [1, 4, 0, -2, -1, 3, 2, 6, 5];
console.log(merge_sort(arr));
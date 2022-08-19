

def merge_sort(arr):
    n = len(arr)
    if n > 1:
        mid = n // 2
        left = merge_sort(arr[:mid])
        right = merge_sort(arr[mid:])
        merge(left, right, arr)
    return arr

def merge(left, right, arr):
    i = j = k = 0
    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            arr[k] = left[i]
            i += 1
        else:
            arr[k] = right[j]
            j += 1
        k += 1
    if i < len(left):
        print("before arr", arr[k:])
        arr[k:] =  left[i:]
        print("after arr", arr)
    else:
        print("before arr", arr)
        arr[k:] = right[j:]
        print("before after", arr)





if __name__ == "__main__":
    arr = [3, 7, 2, 5, 9, 6, 8, 1, 10, 4]
    print(merge_sort(arr))
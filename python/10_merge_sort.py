def merge_sort(arr):
    if len(arr) > 1:
        mid = len(arr) // 2
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
        arr[k:] =  left[i:]
    else:
        arr[k:] = right[j:]

if __name__ == "__main__":
    arr = [4, 5, 1, 2, 3, 0, 6 ]
    print(merge_sort(arr))
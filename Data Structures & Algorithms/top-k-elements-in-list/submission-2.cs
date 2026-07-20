public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new();
        foreach (int num in nums) frequency[num] = frequency.GetValueOrDefault(num) + 1;
        // Min-heap por frecuencia: el menos frecuente queda arriba
        var heap = new PriorityQueue<int, int>();
        foreach (var (num, count) in frequency) {
            heap.Enqueue(num, count);
            if (heap.Count > k)
                heap.Dequeue();  // saca el de menor frecuencia
        }
        var result = new int[k];
        for (int i = k - 1; i >= 0; i--) result[i] = heap.Dequeue();
        return result;
    }
}

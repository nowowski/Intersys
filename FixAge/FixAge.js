function fixage(arr) {
  result = arr.filter((n) => n >= 18 && n <= 60).join();
  return result.length ? result : "NA";
}

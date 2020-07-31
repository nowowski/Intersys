function optionalPow(first, second) {
  if (
    confirm(
      "Would like to raise the first argument to the power determined by the second argument?"
    )
  ) {
    return Math.pow(first, second);
  } else {
    return Math.pow(second, first);
  }
}

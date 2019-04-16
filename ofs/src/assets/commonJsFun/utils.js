let substrTitle = (str, num) => {
  return str.length < num ? str : str.substr(0, num) + '...'
}

export {substrTitle}

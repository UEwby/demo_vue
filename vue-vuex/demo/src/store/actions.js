export const changeMsg = ({commit}) => {
  commit({
    type: 'mutationsMsg',
    msg: '我是修改后的数据'
  })
}

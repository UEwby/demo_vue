export default {
  updateCurrentProtal (state, currentProtal) {
    state.currentProtal = currentProtal
    localStorage.setItem('currentPortal', JSON.stringify({...currentProtal}))
  },
  login: (state, data) => {
    localStorage.setItem(data.otac, data.token)
    state.token = data.token
  },
  logout: (state) => {
    localStorage.removeItem('token')
    state.token = null
  }
}

import { useState, useEffect } from 'react'
import './App.css'
import ImageHandler from './Handler/ImageHandler'
import ImagesList from './components/ImagesList'

function App() {

  // borra el count si no lo vas a usar
  const [count, setCount] = useState(0)
  

 

  return (
    <div className="App">
  

      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>

        <ImagesList />

        

      </div>
    </div>
  )
}

export default App

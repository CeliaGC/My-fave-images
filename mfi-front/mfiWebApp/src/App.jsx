import { useState, useEffect } from 'react'
import reactLogo from './assets/react.svg'
import './App.css'
import ImageService from './Service/ImageService'

function App() {
  const [count, setCount] = useState(0)
  const [images, setImages] = useState([]);

  useEffect(() => {
    getData();
  }, []);
  const getData = async () => {
    const data = await ImageService.getImages();
    setImages(data);
  };

  let myImages = images;

  return (
    <div className="App">
  

      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>

        {myImages.map(i => (
          <div key={i.id}>
              <img src= {i.imageSource} alt="" />
              <h3>{i.imageName}</h3>
            
          </div>
        ))}

        

      </div>
    </div>
  )
}

export default App

import { Route, Routes } from 'react-router-dom'
import About from '../Pages/About/About';
import Home from '../Pages/Home/Home';

function Content() {
    return ( 
        <Routes>
            <Route path='/' element={<Home/>} />
            <Route path='/about' element={<About/>} />
        </Routes>
    );
}

export default Content;
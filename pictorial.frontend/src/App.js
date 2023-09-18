import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import SignUp from './components/SignUp';
import SignIn from './components/SignIn';

function App() {
  return (
    <div>
    <BrowserRouter>
      <Routes>
      <Route path="/" element={<SignUp />}></Route>
      {/* {}
      <Route path="/sign-up" element={<SignUp />}></Route>
      <Route path="/sign-in" element={<SignIn />}></Route>
      */}
      </Routes> 
    </BrowserRouter>
    </div>
  );
}

export default App;

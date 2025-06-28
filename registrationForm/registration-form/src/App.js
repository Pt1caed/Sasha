import './App.css';
import { AuthorizationForm, RegistrationForm } from './Forms'
import { BrowserRouter, Route, Routes } from 'react-router-dom'

function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route index path="/" element={<AuthorizationForm />}></Route>
      <Route path="/registration" element={<RegistrationForm />}></Route>
    </Routes>
    </BrowserRouter>
  );
}

export default App;

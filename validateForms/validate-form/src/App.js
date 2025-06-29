import { useState } from 'react';
import './App.css';
import { FormValidity } from './FormValidate';
import Dialog from '@mui/material/Dialog'
import DialogTitle from '@mui/material/DialogTitle'
import DialogContent from '@mui/material/DialogContent'
import DialogContentText from '@mui/material/DialogContentText'
import DialogActions from '@mui/material/DialogActions'
import Button from '@mui/material/Button'

function App() {
  const [dialogOpen, setDialogOpen] = useState(false);
  const [dialogText, setDialogText] = useState("none");


  return (
    <div className="App">
      <FormValidity setDialogOpen={setDialogOpen} setDialogText={setDialogText}></FormValidity>
      <Dialog open={dialogOpen}>
          <DialogTitle id="titleDialog">
            Data User
          </DialogTitle>
          <DialogContent>
            <DialogContentText className="dialogContentText">
              {dialogText}
            </DialogContentText>
          </DialogContent>
          <DialogActions>
            <Button
              onClick={() => setDialogOpen(false)}
              color="primary"
            >
              Cancel
            </Button>
          </DialogActions>
        </Dialog>
    </div>
  );
}

export default App;

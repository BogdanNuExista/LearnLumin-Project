import React from 'react';
import { Button, Box } from '@mui/material';
import './Home.css';

const Buttons: React.FC = () => {
    return (
        <Box className="auth-buttons" >
            <Button 
                className="auth-button" 
                variant="contained" 
                color="primary"
                sx={{ padding: '0.75rem 1.5rem', fontSize: '1rem' }} // Increased padding and font size
            >
                Register
            </Button>
            <Button 
                className="auth-button" 
                variant="outlined" 
                color="primary"
                sx={{ padding: '0.75rem 1.5rem', fontSize: '1rem' }} // Increased padding and font size
            >
                Login
            </Button>
        </Box>
    );
};

export default Buttons;

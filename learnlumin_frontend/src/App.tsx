import { FC } from "react";
import { createTheme, ThemeProvider } from '@mui/material';
import React from "react";
import { AppHeader } from "./Components/AppHeader";
import { Outlet } from "react-router-dom";

const App: FC = () => {

    const theme = createTheme({
        palette: {
            primary: {
              main: '#6a1b9a',
            },
            secondary: {
              main: '#1565c0',
            },
          },
    });
    
    return(
        <ThemeProvider theme={theme}>
        
            <AppHeader/>
            <Outlet/>

        </ThemeProvider>
    )

};

export default App;
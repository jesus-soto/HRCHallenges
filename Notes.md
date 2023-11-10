### INICIALIZAR  DIRECTORIO GIT

1. Establecer el correo electronico

   ```
   git config --global user.email "jesus.soto.rdz@gmail.com"
   ```
2. Establecer el numbre de usuario

   ```
   git config --global user.name "jesus-soto"
   ```
3. Inicializar el directorio para usarlo con git.

   ```
   git init
   ```
4. Agregar **todo** el contenido del directorio actual

   ```
   git add .
   ```
5. Crear el primer commit

   ```
   git commit -m "Commit Inicial"
   ```
6. Establecer la rama(branch) en la que se trabajara, en el ejemplo la rama es ***main***

   ```
   git branch -M main
   ```
7. Para senalar en que directorio remoto se subiran los cambios realizados.

   ```
   git remote add origin https://github.com/jesus-soto/HRCHallenges.git
   ```
8. Subir los cambios pendientes, donde origin es el directorio remoto y main es la rama(branch) en la que se subiran.

   ```
   git push -u origin main
   ```
9. Crear el primer commit

   ```
   git commit -m "Commit Inicial"
   ```

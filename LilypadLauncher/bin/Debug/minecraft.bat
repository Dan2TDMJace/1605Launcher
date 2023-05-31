@echo off
SET APPDATA=.\appdata
javaw -Xms256m -Xmx256m -cp ".\minecraft.jar;.\jinput.jar;.\lwjgl.jar;.\lwjgl_util.jar" -Djava.library.path=".\natives" net.minecraft.client.Minecraft

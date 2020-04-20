using System.Collections.Generic;

// Class that has localization stuff...

namespace SpaghettiInstaller
{
    public class localizationClass
    {
        public static string ci = System.Globalization.CultureInfo.CurrentUICulture.Name;
        public static Dictionary<string, string> localizationDictionary = new Dictionary<string, string>
        {
#region     // English, default, also duplicated for en-GB. {en}
            ["{en-US}"] = @"{en}",
            ["{en-GB}"] = @"{en}",

            ["mainForm.Text{en}"] =
@"Undertale Together's little C# Installer",
            ["titleLabel.Text{en}"] =
@"Undertale Together
by Depa",
            ["quitButton.Text{en}"] =
@"Quit",
            ["prevButton.Text{en}"] =
@"< Back",
            ["nextButton.Text{en}"] =
@"Next >",
            ["thankyouLabel.Text{en}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Success! Now, launch your game.

$REPLACETEXT$

Mod by: Depa the Dog
SpaghettiInstaller by: Nik the Cat
Arrivederci! (that's ""Goodbye!"" in Italian)",
            ["instructionLabel.Text{en}"] =
@"Buongiorno! (that's ""Hello!"" in Italian)

This installer will help you patch your existing
UNDERTALE copy to include Undertale Together mod.

What you'll need:
1) A legitimate copy of UNDERTALE v1.08 (plz no piracy)
1.1) Anything lower than v1.08 (or 2.0.0.2 on GOG) won't work!
2) A little bit of patience.
3) dog.",
            ["instructionLabel.Text2{en}"] =
@"Buongiorno! (that's ""Hello!"" in Italian)

This installer will help you patch your existing
UNDERTALE copy to include Undertale Together mod.

What you'll need:
1) A legitimate copy of UNDERTALE v1.08 (plz no piracy)
1.1) Anything lower than v1.08 (or 2.0.0.2 on GOG) won't work!
2) A little bit of patience.
3) dog. (not actually required?)", // bau.
            ["errorTitle{en}"] =
@"Uh oh.",
            ["questionTitle{en}"] =
@"Question.",
            ["folderBrowserDialog{en}"] =
@"Please select your UNDERTALE folder:",
            ["steamQuestion{en}"] =
@"Installer autodetected a Steam copy of UNDERTALE, use that?",
            ["gogQuestion{en}"] =
@"Installer autodetected a GOG version of UNDERTALE, do you want to use it or choose a custom path?",
            ["backupErrorQuestion{en}"] =
@"Backing up failed.
Sure, you can proceed, but that's pretty risky.
Do you want to continue anyway?",
            ["steamCannotFindFolder{en}"] =
@"Ummm...",
            ["quitQuestionTitle{en}"] =
@"Such a shame :(",
            ["quitQuestion{en}"] =
@"Are you sure you want to quit?",
            ["runasAdmin{en}"] =
@"Can't write to your game directory.
Please run this patcher as Administrator.",
            ["xdeltaError{en}"] =
@"Can't write xdelta3.exe to temp directory.
Cannot proceed.
Remember what I said about antiviruses?",
            ["dataNotFoundError{en}"] =
@"The folder you selected doesn't contain a data file.
Please choose another directory.",
            ["gogPatch{en}"] =
@"Installer detected that you have a GOG version of Undertale.
It will be autopatched to a Steam version and then to UTTogether.
Press OK to continue.",
            ["veryBadError{en}"] =
@"Got an exception.
Perhaps the file could not be read or it's something else.
Try moving your game to another directory.


Exception: ",
            ["cannotFindModPatch{en}"] =
@"Cannot find patch file.
Please unpack everything from mod archive into a directory.
Don't just run it from your archiver.",
            ["patchingFailed{en}"] =
@"Patching failed.
Remember what I said about antiviruses?",
            ["cannotFindGOGSteam{en}"] =
@"Cannot find GOG->Steam patch, make sure you unpacked everything correctly!",
            ["cannotCopyOptionalFiles{en}"] =
@"Could not copy Optional Files.
Either the folder doesn't exist or something else happened.
This error can be ignored.",
            ["optionalFilesQuestion{en}"] =
@"Do you want to install optional files?",
            ["wrongGameVersion{en}"] =
@"Your data file doesn't seem to match what I was expecting...
Possible reasons:
1) Your game version is wrong, your game version must be 1.08 (last UNDERTALE version), if you want to know how to see your Undertale version see the example.png image.
2) Debug Mode is enabled, reinstall the game from your store (Steam, GOG, Microsoft Store).
3) Other mods are installed (dialogues changes, sprites edits), you need a ""clean"" Undertale, reinstall the game from your store (Steam, GOG, Microsoft Store).
4) The Undertale Together mod is already installed.",
            ["revertModSteam{en}"] =
@"If you want to revert the mod,
press 'Verify Integrity of Game Files'
in UNDERTALE's Properties and remove data.win.bau from UT folder.",
            ["revertModGOG{en}"] =
@"If you want to revert the mod,
Go to your UT folder, delete data.win,
and rename data.win.bau to data.win",
            ["cannotDetectSteamPath{en}"] =
@"Installer found that you have a Steam copy of UNDERTALE but couldn't find it's path...
Perhaps you chose another installation path?\nChoose your UNDERTALE folder after clicking OK.

(let's hope you're not a pirate...)
(it's not an error message and can happen with everyone)",
            ["bauPiracyMsg{en}"] =
@"We herby sincerely apologize, but the dog ate mod patch file.
Try redownloading the mod from https://bit.ly/33LVPOT
(link copied to your clipboard)",
            ["instructionLabel.Text3{en}"] =
@"Okay, in the next step you will be asked to choose
your UNDERTALE directory.

Make sure nothing is blocking this little installer
from overwriting game files.

(perhaps your antivirus?)

Click 'Next' to continue",
            #endregion

#region     // Russian (Vodka Language) {ru}
            ["{ru-RU}"] = @"{ru}",

            ["mainForm.Text{ru}"] =
@"Маленький шарповый установщик Undertale Together",
            ["titleLabel.Text{ru}"] =
@"Undertale Together
от Depa",
            ["quitButton.Text{ru}"] =
@"Выйти",
            ["prevButton.Text{ru}"] =
@"< Назад",
            ["nextButton.Text{ru}"] =
@"Вперёд >",
            ["thankyouLabel.Text{ru}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Success! Now, launch your game.

$REPLACETEXT$

Mod by: Depa the Dog
SpaghettiInstaller by: Nik the Cat
Arrivederci! (that's ""Goodbye!"" in Italian)",
            ["instructionLabel.Text{ru}"] =
@"Чао! (это ""Привет!"" на Итальянском)

Этот установщик поможет вам пропатчить
вашу копию UNDERTALE чтобы установить
мод Undertale Together.

Что вам понадобится:
1) Лицензионная копия UNDERTALE v1.08
1.1) Что-то ниже v1.08 (или 2.0.0.2 на GOG) не подойдёт!
2) Немножко терпения
3) пёся.",
            ["instructionLabel.Text2{ru}"] =
@"Чао! (это ""Привет!"" на Итальянском)

Этот установщик поможет вам пропатчить
вашу копию UNDERTALE чтобы установить
мод Undertale Together.

Что вам понадобится:
1) Лицензионная копия UNDERTALE v1.08
1.1) Что-то ниже v1.08 (или 2.0.0.2 на GOG) не подойдёт!
2) Немножко терпения
3) пёся. (или не нужен???)", // гав.
            ["errorTitle{ru}"] =
@"О нет.",
            ["questionTitle{ru}"] =
@"Вопрос.",
            ["folderBrowserDialog{ru}"] =
@"Пожалуйсту выберите вашу папку с UNDERTALE:",
            ["steamQuestion{ru}"] =
@"Установщик обнаружил вашу стимовскую копию UNDERTALE, пропатчить её?",
            ["gogQuestion{ru}"] =
@"Установщик обнаружил вашу GOG копию UNDERTALE, пропатчить её?",
            ["backupErrorQuestion{ru}"] =
@"Резервное копирование провалено.
Можно конечно и без этого обойтись, но опасно.
Хотите продолжить?",
            ["steamCannotFindFolder{ru}"] =
@"Эммм...",
            ["quitQuestionTitle{ru}"] =
@"Не покидай меня :(",
            ["quitQuestion{ru}"] =
@"Вы уверены что хотите выйти?",
            ["runasAdmin{ru}"] =
@"Не могу записать в вашу папку с игрой.
Запустите патчер от имени Администратора.",
            ["xdeltaError{ru}"] =
@"Не могу записать xdelta3.exe во временную папку.
Патчинг невозможен
(помните что я говорил про антивирусы?)",
            ["dataNotFoundError{ru}"] =
@"Ту папку которую вы выбрали не содержит игровых файлов.
Выберите другую папку.",
            ["gogPatch{ru}"] =
@"Я обнаружил что вы выбрали GOG версию игры,
она будет сначала пропатчена до Steam версии а потом будет установлен мод.
Нажмите ОК чтобы продолжить.",
            ["veryBadError{ru}"] =
@"Ой-ой.
Произошла очень странная ошибка.
Попробуйте переместить игру в другую папку.


Exception: ",
            ["cannotFindModPatch{ru}"] =
@"Не могу найти файл мода.
Пожалуйста распакуйте все файлы из архива.
Не запускайте патчер из архива.",
            ["patchingFailed{ru}"] =
@"Не могу пропатчить игру.
Помните что я говорил про антивирусы?",
            ["cannotFindGOGSteam{ru}"] =
@"Не могу найти GOG->Стим патч, убедитесь что вы всё распаковали верно!",
            ["cannotCopyOptionalFiles{ru}"] =
@"Не могу скопировать дополнительные файлы!
Либо у вас что-то с правами записи либо файлов нет.
Она не критичная.",
            ["optionalFilesQuestion{ru}"] =
@"Хотите установить дополнительные файлы?",
            ["wrongGameVersion{ru}"] =
@"Файл игры не соответствует тому что я ожидал...
Возможные причины:
1) Версия игры не соответствует нужной, она должна быть 1.08 (вроде как последняя), если хотите узнать как посмотреть версию игры, откройте example.png
2) У вас включен дебаг мод, переустановите игру (из Стима, гога, или Microsoft Store).
3) У вас какие-то другие моды (диалоги, спрайтеки), вам нужна ""чистая"" Undertale (ну или как на пиратках писали ""без патчей""), переустановите игру (из Стима, гога, или Microsoft Store).
4) Самое неочевидное, у вас уже установлен мод.",
            ["revertModSteam{ru}"] =
@"Если хотите удалить мод,
в Стиме тыкните ""Проверить целостность файлов игры""
и подождите когда проверка закончится.",
            ["revertModGOG{ru}"] =
@"Если хотите удалить мод,
Зайдите в папку с игрой и удалите data.win,
потом переименуйте data.win.bau в data.win.",
            ["cannotDetectSteamPath{ru}"] =
@"Installer found that you have a Steam copy of UNDERTALE but couldn't find it's path...
Perhaps you chose another installation path?\nChoose your UNDERTALE folder after clicking OK.

(let's hope you're not a pirate...)
(it's not an error message and can happen with everyone)",
            ["bauPiracyMsg{ru}"] =
@"Нам очень жаль, но пёся съела файл патча.
Попробуйте перекачать мод по этой ссылке https://bit.ly/33LVPOT
(ссылка скопирована в ваш буффер обмена)",
            ["instructionLabel.Text3{ru}"] =
@"Окей, в следующем шаге вам будет
предложено выбрать папку с UNDERTALE.

Убедитесь что установщику ничего
не помешает записать в папку с игрой

(возможно ваш антивирус?)

Нажмите 'Вперёд' чтобы продолжить.",
            #endregion

#region     // Italian (Pasta Language/Spaghetti Language) {it}
            ["{it-IT}"] = @"{it}",

            ["mainForm.Text{it}"] =
@"Undertale Together un piccolo installer fatto con C#",
            ["titleLabel.Text{it}"] =
@"Undertale Together
by Depa",
            ["quitButton.Text{it}"] =
@"Esci",
            ["prevButton.Text{it}"] =
@"< Indietro",
            ["nextButton.Text{it}"] =
@"Avanti >",
            ["thankyouLabel.Text{it}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Finito! Avvia il gioco.
 
$REPLACETEXT$
 
Mod by: Depa the Dog
SpaghettiInstaller by: Nik the Cat
Arrivederci!",
            ["instructionLabel.Text{it}"] =
@"Buongiorno!
 
Questo installer ti aiuterà ad applicare
la mod Undertale Together nella
tua esistente copia di UNDERTALE.
 
Requisiti:
1) Una legittima copia di UNDERTALE v1.08
  (please non piratato)
1.1) Qualsiasi versione più piccola di v1.08
    (o 2.0.0.2 se lo hai comprato su GOG) non funzionerà!
2) Un po' di pazienza.
3) Cane.",
            ["instructionLabel.Text2{it}"] =
@"Buongiorno!
 
Questo installer ti aiuterà ad applicare
la mod Undertale Together nella
tua esistente copia di UNDERTALE.
 
Requisiti:
1) Una legittima copia di UNDERTALE v1.08
  (please non piratato)
1.1) Qualsiasi versione più piccola di v1.08
  (o 2.0.0.2 se lo hai comprato su GOG) non funzionerà!
2) Un po' di pazienza.
3) Cane. (non è necessario?)", // bau.
            ["errorTitle{it}"] =
@"Uh oh.",
            ["questionTitle{it}"] =
@"Domanda.",
            ["folderBrowserDialog{it}"] =
@"Per favore seleziona la cartella di UNDERTALE:",
            ["steamQuestion{it}"] =
@"L'installer ha notato che hai una copia di Undertale su Steam, vuoi usare questo??",
            ["gogQuestion{it}"] =
@"L'installer ha notato che hai una copia di Undertale su GOG, vuoi usare questo??",
            ["backupErrorQuestion{it}"] =
@"Backup fallito.
Ovvio, puoi continuare, ma è abbastanza rischioso.
Vuoi continuare comunque?",
            ["steamCannotFindFolder{it}"] =
@"Ummm...",
            ["quitQuestionTitle{it}"] =
@"Che peccato :(",
            ["quitQuestion{it}"] =
@"Sei sicuro di voler uscire?",
            ["runasAdmin{it}"] =
@"Non posso scrivere nella cartella.
Per favore avvia questo installer come Amministratore.",
            ["xdeltaError{it}"] =
@"Non posso scrivere xdelta3.exe nella cartella temporanea.
Non posso procedere.
Ricordi cosa ti avevo detto riguardo gli antivirus?",
            ["dataNotFoundError{it}"] =
@"La cartella che hai selezionato non contiene un data.win file.
Per favore scegli un'altra cartella.",
            ["gogPatch{it}"] =
@"L'installer ha notato che hai una versione GOG di Undertale.
Verrà convertita in una versione Steam e poi in UTTogether.
Premi OK per continuare.",
            ["veryBadError{it}"] =
@"Ricevuta una eccezione.
Pertanto il file non può essere letto o scritto.
Prova a muovere la cartella di gioco in un'altro percorso.
 
 
Eccezione: ",
            ["cannotFindModPatch{it}"] =
@"Non trovo una patch.
Per favore estrai tutto dall'archivio della mod in una cartella.
Non lo eseguire dall'archivio.",
            ["patchingFailed{it}"] =
@"Applicazione della patch fallito.
Ricordi cosa ti avevo detto riguardo gli antivirus?",
            ["cannotFindGOGSteam{it}"] =
@"Non posso trovare la GOG->Steam patch, assicurati di aver estratto tutto correttamente!",
            ["cannotCopyOptionalFiles{it}"] =
@"Non posso copiare i file che stanno nella cartella Optional Files.
O la cartella non esiste o qualcos'altro è successo.
Questo errore può essere ignorato.",
            ["optionalFilesQuestion{it}"] =
@"Vuoi installare i file opzionali?",
            ["wrongGameVersion{it}"] =
@"Il tuo data.win non sembra corrispondere al file del gioco originale...
La causa di questo errore è dovuta per uno di questi motivi:
1) La tua versione di gioco è sbagliata, devi avere la 1.08 (l'ultima versione di UNDERTALE), guarda l'immagine example.png per sapere dove vedere la versione di gioco
2) La debug mode è abilitata, reinstalla UNDERTALE dal tuo store (Steam, GOG, Microsoft Store)
3) Altre mod sono installate (modifiche dei dialoghi, sprite cambiati...), devi avere il gioco ""pulito"", reinstalla UNDERTALE dal tuo store (Steam, GOG, Microsoft Store)
4) Undertale Together mod è già installata",
            ["revertModSteam{it}"] =
@"Se vuoi rimuovere la mod,
premi 'Verifica integrità dei file di gioco'
nelle proprietà di UNDERTALE e rimuovi data.win.bau dalla cartella di UT.",
            ["revertModGOG{it}"] =
@"Se vuoi rimuovere la mod,
Vai nella cartella di UT, rimuovi data.win,
e rinominalo da data.win.bau a data.win",
            ["cannotDetectSteamPath{it}"] =
@"L'installer ha notato che hai una versione di Steam di UNDERTALE ma non trovo questa cartella...
Forse hai scelto un'altra path?
Scegli la tua cartella di UNDERTALE dopo aver cliccato OK.
 
(spero non hai una versione piratata...)
(questo non è un messaggio di errore e può succedere a tutti)",
            ["bauPiracyMsg{it}"] =
@"Ci scusiamo veramente, ma il cane ha mangiato la patch.
Prova a riscaricare la mod qui https://bit.ly/33LVPOT
(link già copiato)",
            ["instructionLabel.Text3{it}"] =
@"Okay, nel prossimo step ti verrà
chiesto di scegliere la tua cartella di UNDERTALE.
 
Assicurati che niente blocchi questo piccolo installer.
 
(Forse il tuo antivirus?)
 
Clicca 'Avanti' per continuare",
            #endregion

#region     // Portoguese {pt} // br???
            ["{pt-BR}"] = @"{pt}",
            ["mainForm.Text{pt}"] =
@"Undertale Together's little C# Installer",
            ["titleLabel.Text{pt}"] =
@"Undertale Together
por Depa",
            ["quitButton.Text{pt}"] =
@"Sair",
            ["prevButton.Text{pt}"] =
@"< Voltar",
            ["nextButton.Text{pt}"] =
@"Proximo >",
            ["thankyouLabel.Text{pt}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Sucesso! agora abra o jogo.
 
$REPLACETEXT$
 
Mod por: Depa O Cachorro
SpaghettiInstaller por: Nik O Gato
Arrivederci! (isso é ""Adeus"" em italiano)",
            ["instructionLabel.Text{pt}"] =
@"Buongiorno! (isso é ""Ola"" em italiano)

Esse instalador vai ajuda - lo colocar o patch do
mod Undertale Together em sua copia de Undertale.

O que voce vai precisar:
1) Uma copia legitima de UNDERTALE v1.08
   (por favor sem piratear)
1.1) Qualquer versão inferior da v1.08
  (ou 2.0.0.2 na GOG) não vai funcionar!
2) Um pouco de paciencia.
3) Cachorro.",
           ["instructionLabel.Text2{pt}"] =
@"Buongiorno! (isso é ""Ola"" em italiano)

Esse instalador vai ajuda - lo colocar o patch do
mod Undertale Together em sua copia de Undertale.

O que voce vai precisar:
1) Uma copia legitima de UNDERTALE v1.08
   (por favor sem piratear)
1.1) Qualquer versão inferior da v1.08
  (ou 2.0.0.2 na GOG) não vai funcionar!
2) Um pouco de paciencia.
3) Cachorro. (não realmente requerido ?)", // bau.
            ["errorTitle{pt}"] =
@"Uh oh.",
            ["questionTitle{pt}"] =
@"Pergunta.",
            ["folderBrowserDialog{pt}"] =
@"Por favor selecione a pasta de seu Undertale:",
            ["steamQuestion{pt}"] =
@"Instalador detecto uma copia de Undertale da Steam usa-la?",
            ["gogQuestion{pt}"] =
@"Instalador detecto uma copia de Undertale da GOG usa-la?",
            ["backupErrorQuestion{pt}"] =
@"Oh backup falhou
Claro você pode continuar mas isso é arriscado.
Você quer continuar de qualquer forma?",
            ["steamCannotFindFolder{pt}"] =
@"Ummm...",
            ["quitQuestionTitle{pt}"] =
@"Mas que pena :(",
            ["quitQuestion{pt}"] =
@"Voce tem certezar que quer sair?",
            ["runasAdmin{pt}"] =
@"Não consegui-mos escrever na pasta de seu jogo.
Por favor abra esse instalador como administrador.",
            ["xdeltaError{pt}"] =
@"Não consegui-mos escrever xdelta3.exe para a pasta temporaria.
Não pode proceder.
Lembra o que falei sobre antivirus?",
            ["dataNotFoundError{pt}"] =
@"A pasta que seleciono não contem um arquivo data
Por favor escolha outra pasta.",
            ["gogPatch{pt}"] =
@"Instalador detecto que você tem uma versão GOG de Undertale.
Ela sera automaticamente modificado para a versão da steam e então UTTogether.
Por favor pressione OK para continuar.",
            ["veryBadError{pt}"] =
@"Pegamos um erro.
Talvez o arquivo não pode ser lido ou é outra coisa.
Tente mover seu game para outra pasta.
 
 
Erro: ",
            ["cannotFindModPatch{pt}"] =
@"Erro não pode encontrar o patch.
Por favor extraia tudo do arquivo do mod na pasta.
Não apenas rode ele do instalador",
            ["patchingFailed{pt}"] =
@"Instalação falhou.
Lembra o que disse sobre antivirus?",
            ["cannotFindGOGSteam{pt}"] =
@"Não pode encontrar o patch GOG->Steam , tenha certeza de ter extraido tudo corretamente!",
            ["cannotCopyOptionalFiles{pt}"] =
@"Não pode copiar os arquivos opcionais.
Ou a pasta não existe ou alguma outra coisa.
Esse erro pode ser ignorado.",
            ["optionalFilesQuestion{pt}"] =
@"Gostaria de instalar os arquivos opcionais?",
            ["wrongGameVersion{pt}"] =
@"Seu arquivo data não parecer ser o que nós esperava...
Possiveis razões:
1) Sua versão do game é errada, sua versão deve ser 1.08(ultima versão de Undertale), se voce quer saber como ver sua versão de Undertale veja a imagem example.png
2) O Modo Debug esta ativado, reinstale o jogo da sua loja(Steam, GOG, Microsoft Store)
3) Outros mods estão instalados (trocas de dialogos, sprites editados), você precisa de um Undertale ""limpo"", reinstale o jogo da sua loja(Steam, GOG, Microsoft Store)
4) O mod Undertale Together ja esta instalado",
            ["revertModSteam{pt}"] =
@"Se você quer reverter o mod,
pressione 'Verificar integridade dos arquivos'
Nas opcões de Undertale e remova data.win.bau da pasta do seu undertale.",
            ["revertModGOG{pt}"] =
@"Se você quer reverter o mod,
Va na pasta de seu Undertale e remova data.win,
e renome-i data.win.bau para data.win",
            ["cannotDetectSteamPath{pt}"] =
@"Instalador detecto-u que você tem uma copia de Undertale da Steam porem não pode detectar o caminho...
Talvez você possa escolher outro caminho de instalação?\nEscolha sua pasta de Undertale depois de pressionar ok.
(Vamos ter esperança de que você não é um pirata...)
(Isso não é uma message de erro e pode acontecer com todo mundo)",
            ["bauPiracyMsg{pt}"] =
@"Sinceramente nos perdoie, mas o cachorro comeu o arquivo patch do mod.
Tente re-baixar o mod de https://bit.ly/33LVPOT
(O link foi automaticamente copiado para você)",
            ["instructionLabel.Text3{pt}"] =
@"Okay, no processo passo você vai ser perguntado para
escolher Sua pasta de Undertale.
 
Tenha certeza de que nada este-ja bloqueando
esse pequeno instalador.
De substituir os seus arquivos de jogo.
 
(Talvez seu anti-virus?)
 
Pressione 'proximo' para continuar",
            #endregion

#region     // Romanian {ro}
            ["{ro-RO}"] = @"{ro}",
            ["mainForm.Text{ro}"] =
@"Undertale Together's micul C# Instalator",
            ["titleLabel.Text{ro}"] =
@"Undertale Together
de Depa",
            ["quitButton.Text{ro}"] =
@"Iesi",
            ["prevButton.Text{ro}"] =
@"< Inapoi",
            ["nextButton.Text{ro}"] =
@"Urmatorul >",
            ["thankyouLabel.Text{ro}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Success! Acum, poti porni jocul. 
 
$REPLACETEXT$
 
Modul facut de: Depa the Dog
SpaghettiInstaller facut de : Nik the Cat
Arrivederci! (este ""La revedere!"" in Italiana)",
            ["instructionLabel.Text{ro}"] =
@"Buongiorno! (este ""Buna!"" in Italiana)
 
Acest instalator va va ajuta sa faceti patch jocului
Copia UNDERTALE  include modul Undertale Together. 
 
Ce iti va trebuii:
1) O copie legitimata UNDERTALE v1.08
  (va rog fara a fi ciordit)
1.1) Orice mai mic decat v1.08
   (ori 2.0.0.2 pe GOG) nu va functiona !
2) putina rabdare .
3) caine.",
            ["instructionLabel.Text2{ro}"] =
@"Buongiorno! (este ""Buna! "" in Italiana)
 
Acest instalator va va ajuta sa faceti patch jocului
Copia UNDERTALE  include modul Undertale Together. 
 
Ce iti va trebuii:
1) O copie legitimata UNDERTALE v1.08
  (va rog fara a fi ciordit)
1.1) Orice mai mic decat v1.08
   (ori 2.0.0.2 pe GOG) nu va functiona !
2) putina rabdare .
3) caine. (nu este folositor?)", // bau.
            ["errorTitle{ro}"] =
@"Uh oh.",
            ["questionTitle{ro}"] =
@"Intrebare.",
            ["folderBrowserDialog{ro}"] =
@"Va rog selectati-va UNDERTALE folder:",
            ["steamQuestion{ro}"] =
@"Instalarea autodetectata a unei copi steam la UNDERTALE, o folositi?",
            ["backupErrorQuestion{ro}"] =
@"Backing up esuat.
Desigur, poti continua, dar este riscant. 
Vrei sa continui oricum?",
            ["steamCannotFindFolder{ro}"] =
@"Ummm...",
            ["quitQuestionTitle{ro}"] =
@"cam rusine.. :(",
            ["quitQuestion{ro}"] =
@"Esti sigur ca vrei sa iesi?",
            ["runasAdmin{ro}"] =
@"nu se poate tipari în  directory jocului .
Va rog porniti acest patcher in Administrator.",
            ["xdeltaError{ro}"] =
@"Nu poate fi scris xdelta3.exe la temp directory.
Nu merge.
Mai ti minte ce ziceam despre antivirusi?",
            ["dataNotFoundError{ro}"] =
@"Folderul pe care l-ai selectat nu este data file.
Va rog alegeti alt directory.",
            ["gogPatch{ro}"] =
@"Instalatorul a detectat ca ai o versiune GOG pentru Undertale.
Va fi autopatchuit la o versiune Steam si după la UTTogether.
Apasa OK pentru a continua.",
            ["veryBadError{ro}"] =
@"Detectata o exceptie.
Din pacate file-ul nu poate fi citit sau este altceva. 
Încearcă sa îti duci jocul în alt directory.
 
 
Exceptie: ",
            ["cannotFindModPatch{ro}"] =

@"Nu se poate gasi patch file.
Va rog faceti unpack la totul din mod si faceti archiva într-un directory.
Nu îl porni direct din arhiva ta.",
            ["patchingFailed{ro}"] =
@"Patching esuat.
Iti zic dinou, îti amintesti ce am zis despre antivirusi?",
            ["cannotFindGOGSteam{ro}"] =
@"Nu se poate gasi GOG->Steam patch, fă-te sigur ca ai făcut unpacked la tot corect !",
            ["cannotCopyOptionalFiles{ro}"] =
@"Nu se pot copia Optional Files.
De asemenea, folderul nu exista sau este altceva. 
Aceasta eroare poate fi ignorata.",
            ["optionalFilesQuestion{ro}"] =
@"Vrei sa instalezi optional files?",
            ["wrongGameVersion{ro}"] =
@"Fisierul tau de date nu pare sa se potriveasca cu ce ma asteptam...
Motive posibile:
1)Versiunea ta de la joc este gresita, deoarece trebuie sa fie versiunea 1.08 (ceea mai noua versiune de la UNDERTALE), dacă vrei sa stii cum sa vezi versiunea de Undertale trebuie sa vezi,exemple.png image (meniul jocului)
2)Debug Mode este permis, reinstalează jocul din magazinul tau (Steam, GOG, Microsoft Store)
3)Alte mod-uri sunt instalate (schimbarile de dialog, editari de sprite-uri) Iti trebuie o copie,, ""curata"" de Undertale, reinstaleaza jocul din magazin(Steam, GOG, Microsoft Store)
4)Modul Undertale Toghether este deja instalat",
            ["revertModSteam{ro}"] =
@"Daca vrei sa revi la mod, 
apasa 'Verify Integrity of Game Files'
in UNDERTALE's Properties si sterge data.win.bau din UT folder.",
            ["revertModGOG{ro}"] =
@"Daca vrei sa revi la mod,
Du-te la UT folder, sterge data.win,
si renumiti data.win.bau in data.win",
            ["cannotDetectSteamPath{ro}"] =
@"Instalatorul a gasit ca ai o copie a versiunei Steam de la UNDERTALE dar nu se poate accesa...
Din pacate ai ales alt path pentru Instalator?\nAlege propiul UNDERTALE folder după ce apesi OK.
 
(sa speram ca nu esti un pirat ciorditor...)
(Nu este un mesaj de eroare si asta apare la oricine)",
            ["bauPiracyMsg{ro}"] =
@" Ne cerem scuze din suflet dar, cainele a mancat patch file-urile de la mod
Încearca sa redescarci modul de aici https://bit.ly/33LVPOT
(link copiat in clipboard)",
            ["instructionLabel.Text3{ro}"] =
@"Okay, urmatorul pas este de a alege
UNDERTALE  din directory-ul tau. 
 
Asigura-te ca nimic nu o sa te blocheze
din acest mic instalator.. 
Din overwriting filele jocului. 
 
(Din pacate este antivirusul? )
 
Apasa 'urmatorul' pentru a continua",
            ["gogQuestion{ro}"] =
@"Instalatorul a detectat o versiune GOG la UNDERTALE, vrei sa o folosesti sau sa alegi un custom path?",
#endregion

#region     // Espanol (paella) language {es}
            ["{es-ES}"] = @"{es}",
            ["mainForm.Text{es}"] =
@"Pequeño instalador C# de Undertale Together",
            ["titleLabel.Text{es}"] =
@"Undertale Together
por Depa",
            ["quitButton.Text{es}"] =
@"Salir",
            ["prevButton.Text{es}"] =
@"< Atras",
            ["nextButton.Text{es}"] =
@"Siguiente >",
            ["thankyouLabel.Text{es}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Exito! Ahora, abre tu juego.
 
$REPLACETEXT$
 
Mod por: Depa el Perro
SpaghettiInstaller por: Nik el Gato
Arrivederci! (eso es ""Adios!"" en Italiano)",
            ["instructionLabel.Text{es}"] =
@"Buongiorno! (eso es ""Hola!"" en Italiano)
 
Este instalador te ayudara a parchear tu existente
copia de UNDERTALE para añadir el
mod Undertale Together.
 
Requisitos:
1) Una copia legitima de UNDERTALE v1.08 (plz no piratas)
1.1) Cualquier version inferior a v1.08
  (o 2.0.0.2 en GOG) no funcionara!
2) Algo de paciencia.
3) perro.",
            ["instructionLabel.Text2{es}"] =
@"Buongiorno! (eso es ""Hola!"" in Italian)
 
Este instalador te ayudara a parchear tu existente
copia de UNDERTALE para añadir el
mod Undertale Together.
 
Requisitos:
1) Una copia legitima de UNDERTALE v1.08 (plz no piratas)
1.1) Cualquier version inferior a v1.08
  (o 2.0.0.2 en GOG) no funcionara!
2) Algo de paciencia.
3) perro. (quizas de hecho no se necesita?)", // bau (ladrido en italiano).
            ["errorTitle{es}"] =
@"Uh oh.",
            ["questionTitle{es}"] =
@"Pregunta.",
            ["folderBrowserDialog{es}"] =
@"Porfavor selecciona tu carpeta de UNDERTALE:",
            ["steamQuestion{es}"] =
@"El instalador detecto automaticamente una copia de UNDERTALE de Steam, usarla?",
            ["backupErrorQuestion{es}"] =
@"Backup fallido.
Claro, puedes continuar, pero tiene riesgo.
Quieres continuar igualmente?",
            ["steamCannotFindFolder{es}"] =
@"Ummm...",
            ["quitQuestionTitle{es}"] =
@"Que pena :(",
            ["quitQuestion{es}"] =
@"Seguro quieres salir?",
            ["runasAdmin{es}"] =
@"No puedes escribir la localizacion del juego.
Porfavor abre el parche como administrador.",
            ["xdeltaError{es}"] =
@"No podemos poner xdelta3.exe en el directorio temporal.
No se puede avanzar.
Recuerdas que dije del antivirus?",
            ["dataNotFoundError{es}"] =
@"La carpeta que seleccionaste no tiene un archivo ''data''.
Por favor elige otro directorio.",
            ["gogPatch{es}"] =
@"El instalador detecta que tienes una version de GOG de Undertale.
Sera autoparcheada a una version de steam y entonces a UTTogether.
Presiona OK para continuar.",
            ["veryBadError{es}"] =
@"Tenemos una excepción.
Quizas no se puede leer el archivo o sea algo mas.
Prueba a mover el juego a otra carpeta.
 
 
Excepción: ",
            ["cannotFindModPatch{es}"] =
@"No podimos encontrar el parche.
Porfavor extrae todo del archivo del mod a una carpeta.
No solo lo abras comprimido.",
            ["patchingFailed{es}"] =
@"Parche fallido.
Recuerdas lo que dije de los antivirus?",
            ["cannotFindGOGSteam{es}"] =
@"No se pudo encontrar un parche de GOG->Steam , asegurate que extraiste todo bien!",
            ["cannotCopyOptionalFiles{es}"] =
@"No pudimos copiar los archivos opcionales.
O la carpeta no existe o algo más pasó.
Este error puede ser ignorado.",
            ["optionalFilesQuestion{es}"] =
@"Quieres instalar los archivos opcionales?",
            ["wrongGameVersion{es}"] =
@"Tu archivo data no es lo que esperaba...
Possibles razones:
1) Tu version de juego es erronea, debe ser 1.08(ultima version de UNDERTALE),si quieres saber como ver tu version de undertale mira la imagen example.png
2) El modo debug esta habilitado, reinstala el juego de tu tienda (Steam, GOG, Microsoft Store)
3) Otros mods estan instalados (Cambios de dialogos,ediciones de sprites), necesitas un Undertale 'limpio', reinstala el juego de tu tienda(Steam, GOG, Microsoft Store)
4) El mod Undertale Together ya está instalado",
            ["revertModSteam{es}"] =
@"Si quieres revertir el mod,
pulsa 'Verificar integridad de los archivos del juego'
en las propiedades de UNDERTALE y borra data.win.bau de la carpeta de UT.",
            ["revertModGOG{es}"] =
@"Si quieres revertir el mod,
Ve a tu carpeta de UT, borra data.win,
y cambia de nombre data.win.bau a data.win",
            ["cannotDetectSteamPath{es}"] =
@"El instalador detecto que tienes una copia de UNDERTALE en Steam pero no puede encontrarla...
Quizas si eliges otro camino de instalación?\nElige tu carpeta de UNDERTALE despues de pulsar OK.
 
(espero que no seas pirata...)
(it's not an error message and can happen with everyone)",
            ["bauPiracyMsg{es}"] =
@"Nos disculpamos muy sinceramente, pero el perro se ha comido el parche.
Prueba a re-descargarlo de https://bit.ly/33LVPOT
(link copiado al portapapeles)",
            ["instructionLabel.Text3{es}"] =
@"Okay, en el siguiente paso tendras que elegir
tu directorio de UNDERTALE.
 
Asegurate que nada bloquee este pequeño instalador
de reemplazar los archivos del juego.
 
(quizá tu antivirus?)
 
Pulsa 'Siguiente' para continuar",
            ["gogQuestion{es}"] =
@"El instalador a autodetectado una version GOG de UNDERTALE, quieres usarla o usar una carpeta alternativa?",
#endregion
        }; // End of localizationDictionary? not yet!
			localizationDictionary["{zh-CN}"] = "{zh}";
			localizationDictionary["{zh-SG}"] = "{zh}";
			localizationDictionary["mainForm.Text{zh}"] = "Undertale Together 的小小 C# 补丁机";
			localizationDictionary["titleLabel.Text{zh}"] = "Undertale Together\n作者：Depa";
			localizationDictionary["quitButton.Text{zh}"] = "退出";
			localizationDictionary["prevButton.Text{zh}"] = "< 上一页";
			localizationDictionary["nextButton.Text{zh}"] = "下一页 >";
			localizationDictionary["thankyouLabel.Text{zh}"] = "补丁成功！现在请打开你的游戏。\n\n$REPLACETEXT$\n\nMod作者：小狗Depa\nSpaghettiInstaller 作者：小猫Nik\nzh-CN/zh-SG翻译：Dobby233Liu\n再见！";
			localizationDictionary["instructionLabel.Text{zh}"] = "你好！\n\n该安装程序将帮助您补丁已存的\nUNDERTALE 副本以包含 Undertale Together 这个 mod。\n\n您需要：\n1) 合法的 UNDERTALE v1.08 副本（盗版臭死了，\n请在24小时内自裁，请）\n1.1) 版本号低于 v1.08 的副本\n（或 GOG 上的 2.0.0.2）行不通！\n2) 一点耐心。\n3) 两只狗。";
			localizationDictionary["instructionLabel.Text2{zh}"] = localizationDictionary["instructionLabel.Text{zh}"] + "（非必须？）";
			localizationDictionary["errorTitle{zh}"] = "啊哦。";
			localizationDictionary["questionTitle{zh}"] = "请施教。";
			localizationDictionary["folderBrowserDialog{zh}"] = "请选择副本文件夹：";
			localizationDictionary["steamQuestion{zh}"] = "安装程序检测到一份 UNDERTALE 的 Steam 副本，是否使用？";
			localizationDictionary["gogQuestion{zh}"] = "安装程序检测到一份 UNDERTALE 的 GOG 副本，试问是要使用还是自己选一个目录？";
			localizationDictionary["backupErrorQuestion{zh}"] = "备份失败。\n您仍可以继续，但到时问题可能就大了。\n您仍要继续吗？";
			localizationDictionary["steamCannotFindFolder{zh}"] = "额...";
			localizationDictionary["quitQuestionTitle{zh}"] = "真可惜 :(";
			localizationDictionary["quitQuestion{zh}"] = "您确定要退出吗？";
			localizationDictionary["runasAdmin{zh}"] = "无法在游戏目录里进行写操作。\n请以管理员身份重新运行该安装程序。";
			localizationDictionary["xdeltaError{zh}"] = "无法在临时文件夹里写 xdelta3.exe。\n安装程序无法继续。\n记得我提起过杀毒软件吗？";
			localizationDictionary["dataNotFoundError{zh}"] = "您所选的目录内没有数据文件。\n请选择另一个目录。";
			localizationDictionary["gogPatch{zh}"] = "安装程序检测到您的 UNDERTALE 副本为 GOG 版本。\n它将会先被转换为 Steam 版本。\n请按确定键继续。";
			localizationDictionary["veryBadError{zh}"] = "安装程序捕获到一个异常。\n文件可能不可读或与预期值不同。\n尝试将游戏目录移动到别处。\n\n\n异常：";
			localizationDictionary["cannotFindModPatch{zh}"] = "无法找到补丁文件。\n请将所有文件解压。\n不要只解压此安装程序。";
			localizationDictionary["patchingFailed{zh}"] = "打补丁失败。\n记得我提起过杀毒软件吗？";
			localizationDictionary["cannotFindGOGSteam{zh}"] = "找不到 GOG 转 Steam 补丁，请确保您有正确地解压所有文件！";
			localizationDictionary["cannotCopyOptionalFiles{zh}"] = "无法拷贝附加文件。\n对应的文件夹极有可能不存在。\n您可以忽略此错误。";
			localizationDictionary["optionalFilesQuestion{zh}"] = "您想要安装附加文件吗？";
			localizationDictionary["wrongGameVersion{zh}"] = "你的数据文件跟我所预期的不一样...\n可能原因：\n1) 游戏版本不同，其必须为1.08\n2) 安装了其他的 mod，请重装游戏\n3) Undertale Together 早已被安装了。";
			localizationDictionary["revertModSteam{zh}"] = "如果想要撤消补丁，\n请在 UNDERTALE 的属性内按”验证游戏文件完整性“，\n并在 UT 目录内删除 data.win.bau";
			localizationDictionary["revertModGOG{zh}"] = "如果想要撤消补丁，\n请进入游戏目录，删除 data.win，\n并重命名 data.win.bau 为 data.win";
			localizationDictionary["cannotDetectSteamPath{zh}"] = "安装程序检测到一份 UNDERTALE 的 Steam 副本，但无法找到其位置...\n也许你选择了另一个安装路径？\n按确定以选择游戏目录。\n\n(let's hope you're not a pirate...)\n(it's not an error message and can happen to everyone)";
			localizationDictionary["bauPiracyMsg{zh}"] = "我们为神烦狗吃掉补丁文件而深感歉意。\n尝试从 https://bit.ly/33LVPOT 重新下载补丁\n（链接已复制）";
			localizationDictionary["instructionLabel.Text3{zh}"] = "下一步，您将要选择您的游戏目录。\n\n请保证没有东西会阻止安装程序重写游戏文件。\n（比如杀毒软件？）\n\n按”下一页“继续";
    }
}

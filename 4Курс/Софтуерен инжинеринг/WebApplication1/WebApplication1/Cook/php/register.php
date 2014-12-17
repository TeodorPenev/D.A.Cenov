<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Village</title>
  <link rel="stylesheet" type="text/css" href="../styles/reset.css" />
  <link rel="stylesheet" type="text/css" href="../styles/register.css" />
</head>
<body>
<div id="bg">
  <div id="registration">
    <section class="register">
      <h1>Регистрация</h1>
      <form method="post" action="">
      <div class="reg_section personal_info">
      <h3>Лична информация</h3>
      <input type="text" name="firstName" value="" placeholder="Вашето име" required pattern=".{2,30}" title="минимум 2 символа, максимум 30">
      <input type="text" name="lastName" value="" placeholder="Вашата фамилия" required pattern=".{2,30}" title="минимум 2 символа, максимум 30">
      <input type="text" name="username" value="" placeholder="Потребителско име" required pattern=".{4,16}" title="минимум 4 символа, максимум 16">
      <input type="email" name="email" value="" placeholder="E-mail адрес" required pattern=".{6,60}" title="максимум 60 символа">
      </div>
      <div class="reg_section password">
      <h3>Парола</h3>
      <input type="password" id="password" name="password" value="" placeholder="Въведете парола" required pattern=".{6,64}" title="Tрябва да съвпада! Mинимум 6 символа, максимум 64">
      <input type="password" id="confirmPassword" name="confirmPassword" value="" placeholder="Повторете паролата" required pattern=".{6,64}" title="Tрябва да съвпада! Mинимум 6 символа, максимум 64">
      </div>
      <div class="reg_section password">
      <h3>Пол</h3>
      <select name="sex" id="sex" required title="трябва да избереш">
        <option value="" disabled selected>Избери</option>
        <option value="1" required>Мъж</option>
        <option value="2" required>Жена</option>
      </select>

      </div>
      <p class="submit"><input onclick="javascript:checkPassword()" type="submit" name="submit" value="Регистрация"></p>
      </form>
    </section>

    <script type="text/javascript">
    function checkPassword()
    {
      if ( $('#password').val() != $('#confirmPassword').val() )
      {
        $('#password').val("");
        $('#confirmPassword').val("");

        return false;
      }
    }
    </div>
   </div>
</body>
</html>
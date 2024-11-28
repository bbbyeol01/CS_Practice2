# Cafe Kiosk
C#으로 구현한 카페 키오스크입니다. WinForm을 사용하여 윈도우 애플리케이션을 개발했습니다. MySQL을 연동하여 메뉴와 재고를 관리할 수 있습니다. 

<br>


### 기간
24. 11 . 05 ~ 24. 11. 08 (3일)
   
<br>

### 기술 스택
![CSharp](https://img.shields.io/badge/CSharp-6C47FF?style=flat&logo=Cplusplus&logoColor=white)
![WinForm](https://img.shields.io/badge/WinForm-000000?style=flat&logo=&logoColor=white)
![Mysql](https://img.shields.io/badge/MySQL-4479A1?style=flat&logo=mysql&logoColor=white)



<br>

### UI
<p align="left">
  <img src="https://github.com/user-attachments/assets/e6e8ab40-1464-4710-a934-65711449a009" width="45%" />
  <img src="https://github.com/user-attachments/assets/9f07b754-4be2-40dd-a452-b3ecb17733bb" width="45%" />
</p>

<p align="left">
  <img src="https://github.com/user-attachments/assets/05faddd5-437e-4c54-958f-6bddb805ef00" width="45%" />
  <img src="https://github.com/user-attachments/assets/d55401b6-ab60-4572-92e3-bc3befff89a5" width="45%" />
</p>
* 각 음료 사진의 출처는 https://www.banapresso.com 입니다. 


<br>
<br>


```csharp
// MenuItem

namespace Coffee_Kiosk
{
    public partial class MenuItem : UserControl
    {

        public delegate void AddDrinkHandler(Drink drink);
        public event AddDrinkHandler addDrink;

// ...


        private void MenuItem_Click(object sender, EventArgs e)
        {
            ShadowForm shadow = new ShadowForm();
            shadow.Show();

            Drink drink = new Drink();
            drink.Idx = this.drinkInfo.Idx;
            drink.Name = this.drinkInfo.Name;
            drink.Price = this.drinkInfo.Price;
            drink.DrinkImage = Pic_drink;
            drink.Desc = this.drinkInfo.Description;

            SelectOptionForm selectOptionForm = new SelectOptionForm(drink);
            selectOptionForm.addDrink += AddDrink;

            // shadow 창 누르면 둘 다 꺼짐
            shadow.Click += (s, args) => { 
                selectOptionForm.Dispose();
                shadow.Dispose();
            };

            // selectoptionform이 꺼지면 shadow도 꺼짐
            selectOptionForm.FormClosed += (s, args) => shadow.Dispose();
            selectOptionForm.Show();

        }

        private void AddDrink(Drink drink)
        {
            addDrink.Invoke(drink);
        }

    }
}
```

```csharp
// SelectOptionForm

namespace Coffee_Kiosk.View
{
    public partial class SelectOptionForm : Form
    {
        Drink drink;
        MenuRepository menuRepository = new MenuRepository();
        int selectDrinkPrice;

        public delegate void AddDrinkHandler(Drink drink);
        public event AddDrinkHandler addDrink;

        public SelectOptionForm(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            this.selectDrinkPrice = drink.Price;
            
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            addDrink.Invoke(drink);
            this.Close();
        }
    }
}
```
메인 폼인 <code>SellForm</code>에서 음료 하나를 표시하는 Controls인 <code>MenuItem</code>를 생성합니다.
<code>MenuItem</code>에서는 옵션을 선택하는 Controls인 <code>selectOptionForm</code>를 생성합니다.
이때 메뉴가 추가되면 메인 폼인 <code>SellForm</code>의 하단 panel에 추가된 메뉴가 표시되어야 하기 때문에, 하위 폼에서 상위 폼을 수정하기 위하여 `delegate`와 `invoke()` 함수를 사용했습니다.


<br>

### ERD
![ERD](https://github.com/user-attachments/assets/5e21c00f-7e02-4e10-ae8a-96cf8b24ba4f)

<br>

### 아키텍쳐
<img width="600" alt="image" src="https://github.com/user-attachments/assets/fc1accaa-e03e-423b-aac4-130ac0eb1480">

<br>




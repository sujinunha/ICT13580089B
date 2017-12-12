using Xamarin.Forms;

namespace ICT13580089B
{
    public partial class ICT13580089BPage : ContentPage
    {
        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        public ICT13580089BPage()
        {
            InitializeComponent();


            okbutton.Clicked += Okbutton_Clicked;
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");
            mySlider.ValueChanged += MySlider_ValueChanged1;
            myStepper.ValueChanged += MyStepper_ValueChanged;

        }



        void Okbutton_Clicked(object sender, System.EventArgs e)
        {
            firsNameLabel.Text = firsNameEntry.Text;
        }

        void MySlider_ValueChanged1(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = valueLabel.ToString();
        }




    void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = valueLabel.ToString();
                              
        }
    }}

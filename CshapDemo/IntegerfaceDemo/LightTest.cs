using System;
using System.Threading.Tasks;

namespace name.heby.IntegerfaceDemo
{

    /// <summary>
    /// 基本Light接口
    /// </summary>
    public interface ILight
    {
        void SwitchOn();
        void SwitchOff();
        bool IsOn();
    }

    /// <summary>
    /// 高脚灯
    /// </summary>
    public class OverheadLight : ILight
    {
        private bool isOn;
        public bool IsOn() => isOn;
        public void SwitchOff() => isOn = false;
        public void SwitchOn() => isOn = true;

        public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
    }

    /// <summary>
    /// 自动关灯接口
    /// </summary>
    public interface ITimerLight : ILight
    {
        
    }
    
    public class LightTest
    {
        
    }
}
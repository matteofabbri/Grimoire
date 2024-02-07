using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Multiple_Choice_Question_Option_DataType : INotifyPropertyChanged
	{
		private string multiple_Choice_Question_Option_OrderField;

		private string multiple_Choice_Quesiton_Option_TextField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Multiple_Choice_Question_Option_Order
		{
			get
			{
				return this.multiple_Choice_Question_Option_OrderField;
			}
			set
			{
				this.multiple_Choice_Question_Option_OrderField = value;
				this.RaisePropertyChanged("Multiple_Choice_Question_Option_Order");
			}
		}

		[XmlElement(Order = 1)]
		public string Multiple_Choice_Quesiton_Option_Text
		{
			get
			{
				return this.multiple_Choice_Quesiton_Option_TextField;
			}
			set
			{
				this.multiple_Choice_Quesiton_Option_TextField = value;
				this.RaisePropertyChanged("Multiple_Choice_Quesiton_Option_Text");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

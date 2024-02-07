using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Airport_DataType : INotifyPropertyChanged
	{
		private string spend_Data_IDField;

		private string airport_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Data_ID
		{
			get
			{
				return this.spend_Data_IDField;
			}
			set
			{
				this.spend_Data_IDField = value;
				this.RaisePropertyChanged("Spend_Data_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Airport_Value
		{
			get
			{
				return this.airport_ValueField;
			}
			set
			{
				this.airport_ValueField = value;
				this.RaisePropertyChanged("Airport_Value");
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

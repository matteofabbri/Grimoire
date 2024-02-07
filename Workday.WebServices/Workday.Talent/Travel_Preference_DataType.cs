using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Travel_Preference_DataType : INotifyPropertyChanged
	{
		private Mobility_ChoiceObjectType willing_to_Travel_ReferenceField;

		private Travel_AmountObjectType travel_Amount_ReferenceField;

		private string travel_Additional_InformationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Mobility_ChoiceObjectType Willing_to_Travel_Reference
		{
			get
			{
				return this.willing_to_Travel_ReferenceField;
			}
			set
			{
				this.willing_to_Travel_ReferenceField = value;
				this.RaisePropertyChanged("Willing_to_Travel_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Travel_AmountObjectType Travel_Amount_Reference
		{
			get
			{
				return this.travel_Amount_ReferenceField;
			}
			set
			{
				this.travel_Amount_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Amount_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Travel_Additional_Information
		{
			get
			{
				return this.travel_Additional_InformationField;
			}
			set
			{
				this.travel_Additional_InformationField = value;
				this.RaisePropertyChanged("Travel_Additional_Information");
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

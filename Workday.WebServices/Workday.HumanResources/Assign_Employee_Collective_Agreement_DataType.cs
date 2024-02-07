using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Employee_Collective_Agreement_DataType : INotifyPropertyChanged
	{
		private Position_ElementObjectType position_ReferenceField;

		private Collective_AgreementObjectType collective_Agreement_ReferenceField;

		private Collective_Agreement_Factor_Options_DataType factor_OptionsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Collective_AgreementObjectType Collective_Agreement_Reference
		{
			get
			{
				return this.collective_Agreement_ReferenceField;
			}
			set
			{
				this.collective_Agreement_ReferenceField = value;
				this.RaisePropertyChanged("Collective_Agreement_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Collective_Agreement_Factor_Options_DataType Factor_Options
		{
			get
			{
				return this.factor_OptionsField;
			}
			set
			{
				this.factor_OptionsField = value;
				this.RaisePropertyChanged("Factor_Options");
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

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
	public class Position_Succession_DataType : INotifyPropertyChanged
	{
		private string position_IDField;

		private bool succession_Plan_InactiveField;

		private bool succession_Plan_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Position_ID
		{
			get
			{
				return this.position_IDField;
			}
			set
			{
				this.position_IDField = value;
				this.RaisePropertyChanged("Position_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Succession_Plan_Inactive
		{
			get
			{
				return this.succession_Plan_InactiveField;
			}
			set
			{
				this.succession_Plan_InactiveField = value;
				this.RaisePropertyChanged("Succession_Plan_Inactive");
			}
		}

		[XmlIgnore]
		public bool Succession_Plan_InactiveSpecified
		{
			get
			{
				return this.succession_Plan_InactiveFieldSpecified;
			}
			set
			{
				this.succession_Plan_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Succession_Plan_InactiveSpecified");
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

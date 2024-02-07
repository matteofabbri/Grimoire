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
	public class Committee_ClassificationType : INotifyPropertyChanged
	{
		private Committee_ClassificationObjectType committee_Classification_ReferenceField;

		private Committee_Classification_DataType[] committee_Classification_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_ClassificationObjectType Committee_Classification_Reference
		{
			get
			{
				return this.committee_Classification_ReferenceField;
			}
			set
			{
				this.committee_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Classification_Reference");
			}
		}

		[XmlElement("Committee_Classification_Data", Order = 1)]
		public Committee_Classification_DataType[] Committee_Classification_Data
		{
			get
			{
				return this.committee_Classification_DataField;
			}
			set
			{
				this.committee_Classification_DataField = value;
				this.RaisePropertyChanged("Committee_Classification_Data");
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

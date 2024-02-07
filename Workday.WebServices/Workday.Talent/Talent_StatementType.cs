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
	public class Talent_StatementType : INotifyPropertyChanged
	{
		private Talent_StatementObjectType talent_Statement_ReferenceField;

		private Talent_Statement_Detail_DataType talent_Statement_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Talent_StatementObjectType Talent_Statement_Reference
		{
			get
			{
				return this.talent_Statement_ReferenceField;
			}
			set
			{
				this.talent_Statement_ReferenceField = value;
				this.RaisePropertyChanged("Talent_Statement_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Talent_Statement_Detail_DataType Talent_Statement_Detail_Data
		{
			get
			{
				return this.talent_Statement_Detail_DataField;
			}
			set
			{
				this.talent_Statement_Detail_DataField = value;
				this.RaisePropertyChanged("Talent_Statement_Detail_Data");
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

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
	public class Former_Worker_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Former_Worker_AttachmentsField;

		private bool include_Former_Worker_AttachmentsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Former_Worker_Attachments
		{
			get
			{
				return this.include_Former_Worker_AttachmentsField;
			}
			set
			{
				this.include_Former_Worker_AttachmentsField = value;
				this.RaisePropertyChanged("Include_Former_Worker_Attachments");
			}
		}

		[XmlIgnore]
		public bool Include_Former_Worker_AttachmentsSpecified
		{
			get
			{
				return this.include_Former_Worker_AttachmentsFieldSpecified;
			}
			set
			{
				this.include_Former_Worker_AttachmentsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Former_Worker_AttachmentsSpecified");
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

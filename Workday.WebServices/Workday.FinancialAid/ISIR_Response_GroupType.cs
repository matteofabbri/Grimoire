using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ISIR_Response_GroupType : INotifyPropertyChanged
	{
		private bool show_OriginalField;

		private bool show_OriginalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Show_Original
		{
			get
			{
				return this.show_OriginalField;
			}
			set
			{
				this.show_OriginalField = value;
				this.RaisePropertyChanged("Show_Original");
			}
		}

		[XmlIgnore]
		public bool Show_OriginalSpecified
		{
			get
			{
				return this.show_OriginalFieldSpecified;
			}
			set
			{
				this.show_OriginalFieldSpecified = value;
				this.RaisePropertyChanged("Show_OriginalSpecified");
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

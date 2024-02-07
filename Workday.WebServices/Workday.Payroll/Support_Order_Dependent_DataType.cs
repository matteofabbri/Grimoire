using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Support_Order_Dependent_DataType : INotifyPropertyChanged
	{
		private string child_s_Name__Last__First__MI_Field;

		private DateTime child_s_Birth_DateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Child_s_Name__Last__First__MI_
		{
			get
			{
				return this.child_s_Name__Last__First__MI_Field;
			}
			set
			{
				this.child_s_Name__Last__First__MI_Field = value;
				this.RaisePropertyChanged("Child_s_Name__Last__First__MI_");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Child_s_Birth_Date
		{
			get
			{
				return this.child_s_Birth_DateField;
			}
			set
			{
				this.child_s_Birth_DateField = value;
				this.RaisePropertyChanged("Child_s_Birth_Date");
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
